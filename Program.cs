// See https://aka.ms/new-console-template for more information
using TaxCalculatorInterviewTests;

TaxCalculator tx = new TaxCalculator();

tx.SetCustomTaxRate(Commodity.Literature, 5);

//Console.WriteLine(TaxCalculator._customRates);

foreach (KeyValuePair<Commodity, Tuple<DateTime, double>> kvp in TaxCalculator._customRates)
{
    Console.WriteLine("Key = [0], Value = {1}", kvp.Key, kvp.Value);
}

var value = tx.GetTaxRateForDateTime(Commodity.Literature, DateTime.Now);

Console.WriteLine(value);

