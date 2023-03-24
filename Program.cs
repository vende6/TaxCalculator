// See https://aka.ms/new-console-template for more information
using TaxCalculatorInterviewTests;

TaxCalculator tx = new TaxCalculator();

tx.SetCustomTaxRate(Commodity.Literature, 5);
tx.SetCustomTaxRate(Commodity.Literature, 6);
tx.SetCustomTaxRate(Commodity.CulturalServices, 10);

foreach (KeyValuePair<Commodity, Tuple<DateTime, double>> kvp in TaxCalculator._customRates)
{
    Console.WriteLine("Key = [0], Value = {1}", kvp.Key, kvp.Value);
}

var taxvalue = tx.GetTaxRateForDateTime(Commodity.Literature, DateTime.Now);

Console.WriteLine("GetTaxRateForDateTime"+ " :: " + taxvalue);

var currentvalue = tx.GetCurrentTaxRate(Commodity.CulturalServices);

Console.WriteLine("GetCurrentTaxRate" + " :: " + currentvalue);

