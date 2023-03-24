// See https://aka.ms/new-console-template for more information
using TaxCalculatorInterviewTests;

TaxCalculator tx = new TaxCalculator();

tx.SetCustomTaxRate(Commodity.Literature, 5);
tx.SetCustomTaxRate(Commodity.Literature, 6);
//tx.SetCustomTaxRate(Commodity.CulturalServices, 10);

foreach (var kvp in TaxCalculator._customRates)
{
    if(kvp!=null)
    Console.WriteLine("Key = [0], Value = {1},  Value = {2}", kvp.Item1, kvp.Item2, kvp.Item3);
}

var taxvalue = tx.GetTaxRateForDateTime(Commodity.Literature, DateTime.Now);

Console.WriteLine("GetTaxRateForDateTime"+ " :: " + taxvalue);

var currentvalue = tx.GetCurrentTaxRate(Commodity.CulturalServices);

Console.WriteLine("GetCurrentTaxRate" + " :: " + currentvalue);

