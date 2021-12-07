using System;
using System.Text.RegularExpressions;
using System.IO;
using MoneyManagerIO.DatabaseContext.MoneyManager2;
using System.Collections.Generic;
using System.Linq;

namespace FixCurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MoneyManager2DbContext dbContext = new MoneyManager2DbContext(GetPath()))
            {
                {
                    Console.Write("Single currency...");
                    Regex singleCurrencyRegEx = new Regex(@"^([A-Z]{3})\s*([\d\.]+)$");
                    IEnumerable<ZInOutcome> records = dbContext.ZInOutcomes.Where(x => x.ZMemo != null).ToList()
                        .Where(x => singleCurrencyRegEx.IsMatch(x.ZMemo));
                    Console.Write($"{records.Count()} records found...");
                    foreach (ZInOutcome record in records)
                    {
                        Match match = singleCurrencyRegEx.Match(record.ZMemo);
                        string targetCurrency = match.Groups[1].Captures[0].Value.ToString();
                        double amount = double.Parse(match.Groups[2].Captures[0].Value.ToString());

                        record.ZCurrencyUid = $"THB_{targetCurrency}";
                        record.ZAmountAccount = amount;
                        record.ZAmountSub = amount;
                    }
                    Console.Write("Writing changes...");
                    dbContext.SaveChanges();
                    Console.WriteLine("Done");
                }
                {
                    Console.Write("Multiple currency...");
                    Regex multipleCurrencyRegEx = new Regex(@"([A-Z]{3})\s*([0-9\.]*)\s*→\s*([A-Z]{3})\s*([0-9\.]*)");
                    List<ZInOutcome> records = dbContext.ZInOutcomes
                        .Where(x => (x.ZDoType == "3" || x.ZDoType == "4") && x.ZCurrencyUid == "THB_THB" && x.ZMemo != null).ToList()
                        .Where(x => multipleCurrencyRegEx.IsMatch(x.ZMemo)).ToList();
                    Console.Write($"{records.Count()} records found...");

                    foreach (ZInOutcome record in records)
                    {
                        Match match = multipleCurrencyRegEx.Match(record.ZMemo);
                        string fromCurrency = match.Groups[1].Captures[0].ToString();
                        double fromAmount = double.Parse(match.Groups[2].Captures[0].ToString());
                        string toCurrency = match.Groups[3].Captures[0].ToString();
                        double toAmount = double.Parse(match.Groups[4].Captures[0].ToString());

                        if (fromCurrency == "THB")
                        {
                            record.ZCurrencyUid = $"THB_{toCurrency}";
                            if (record.ZDoType == "3")
                            {
                                record.ZAmountAccount = fromAmount;
                                record.ZAmountSub = toAmount;
                            }
                            else if (record.ZDoType == "4")
                            {
                                record.ZAmountAccount = toAmount;
                                record.ZAmountSub = toAmount;
                            }
                        }
                        else if (toCurrency == "THB")
                        {
                            record.ZCurrencyUid = $"THB_{toCurrency}";
                            if (record.ZDoType == "3")
                            {
                                record.ZAmountAccount = fromAmount;
                                record.ZAmountSub = fromAmount;
                            }
                            else if (record.ZDoType == "4")
                            {
                                record.ZAmountAccount = toAmount;
                                record.ZAmountSub = fromAmount;
                            }
                        }
                        else
                        {
                            throw new Exception("Invalid currency");
                        }
                    }
                    Console.Write("Writing changes...");

                    dbContext.SaveChanges();

                    Console.WriteLine("Done");
                }
                {
                    Console.Write("Removing old adjustment...");
                    List<ZInOutcome> records = dbContext.ZInOutcomes
                        .Where(x => x.ZContent == "差額" && x.ZCardDivideUid != null)
                        .ToList();
                    Console.Write($"{records.Count()} records found...Removing...");
                    dbContext.ZInOutcomes.RemoveRange(records);
                    Console.Write("Writing changes...");

                    dbContext.SaveChanges();

                    Console.WriteLine("Done");
                }
                {
                    Console.Write("Adjusting non-baht same currency transfers...");
                    IDictionary<string, string> assetCurrencies = dbContext.ZAssets
                        .ToDictionary(x => x.ZUid, x => x.ZCurrencyUid);
                    List<ZInOutcome> incorrectCurrencyRecords = dbContext.ZInOutcomes
                        .Where(x => x.ZDoType == "3").ToList()
                        .Where(x => assetCurrencies.ContainsKey(x.ZAssetUid) && assetCurrencies.ContainsKey(x.ZToAssetUid)
                            && assetCurrencies[x.ZAssetUid] == assetCurrencies[x.ZToAssetUid]
                            && assetCurrencies[x.ZAssetUid] != "THB_THB" && assetCurrencies[x.ZAssetUid] != "THB_THB"
                            && x.ZCurrencyUid == "THB_THB")
                        .ToList();
                    Console.Write($"{incorrectCurrencyRecords.Count()} records found...");
                    foreach (ZInOutcome record in incorrectCurrencyRecords)
                    {
                        ZInOutcome receiveTransaction = dbContext.ZInOutcomes.Where(x => x.ZTxUidTrans == record.ZTxUidTrans && x.ZDoType == "4").SingleOrDefault();
                        if (receiveTransaction == null)
                        {
                            throw new Exception("No receive transactions...");
                        }
                        record.ZAmountAccount = record.ZAmountSub;
                        record.ZCurrencyUid = assetCurrencies[record.ZAssetUid];
                        receiveTransaction.ZAmountAccount = receiveTransaction.ZAmountSub;
                        receiveTransaction.ZCurrencyUid = assetCurrencies[receiveTransaction.ZAssetUid];
                    }
                    Console.Write("Writing changes...");

                    dbContext.SaveChanges();

                    Console.WriteLine("Done");
                }
            }
        }

        static string GetPath()
        {
            Directory.CreateDirectory("./out");
            string outPath = "./out/data.MoneyManager2";
            File.Copy("./data/data.MoneyManager2", outPath, true);
            return outPath;
        }
    }
}
