using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CsvHelper;
using MoneyManagerIO.DatabaseContext.MoneyManager2;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string dbPath = "./data/temp.MoneyManager2";
            File.Copy("./data/backup.MoneyManager2", "./data/temp.MoneyManager2", true);

            Directory.CreateDirectory("./out");

            using (MoneyManager2DbContext dbContext = new MoneyManager2DbContext(dbPath))
            {
                Regex regex = new Regex(@"([A-Z]{3})\s*([0-9\.]*)\s*→\s*([A-Z]{3})\s*([0-9\.]*)");
                List<ZInOutcome> multiCurrencyRecords = dbContext.ZInOutcomes.Where(x => x.ZMemo != null).ToList().Where(x => regex.IsMatch(x.ZMemo)).ToList();
                
                using (StreamWriter writer = new StreamWriter("./out/records.csv"))
                using (CsvWriter csvWriter = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords<ZInOutcome>(multiCurrencyRecords);
                }
            }

            Console.WriteLine("OK");
        }
    }
}
