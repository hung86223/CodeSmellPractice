using System;
using System.Globalization;

namespace FeatureEnvyTest
{
    internal class LongMethod
    {
        private bool ValidateRequest(CustomerInquiryRequest request,
            int customerIDFieldLength, int productFieldLength)
        {
            if (request.CustomerProduct.ProductNumber != null &&
                request.Customer.CustomerID != null)
            {
                if (request.CustomerProduct.ProductNumber != string.Empty &&
                    request.Customer.CustomerID != string.Empty)
                {
                    // Both were populated
                    Console.WriteLine("Error");
                }
                else if (request.Customer.CustomerID == string.Empty &&
                         request.CustomerProduct.ProductNumber == string.Empty)
                {
                    // if objects were instantiated but not populated
                    Console.WriteLine("Error");
                }
                else if (request.Customer.CustomerID != string.Empty)
                {
                    // Note: ProductNumber was equal
                    // to string.empty Check Customer ID length
                    if (request.Customer.CustomerID.Length >
                        customerIDFieldLength)
                    {
                        Console.WriteLine("Error");
                    }
                }
                else
                {
                    // Note: CustomerID was equal
                    // to string.empty check Product Length
                    if (request.CustomerProduct.ProductNumber.Length >
                        productFieldLength)
                    {
                        Console.WriteLine("Error");
                    }
                }
            }
            else if (request.CustomerProduct.ProductNumber == null &&
                     request.Customer.CustomerID == null)
            {
                // Both were null
                Console.WriteLine("Error");
            }
            else if (request.CustomerProduct.ProductNumber == null)
            {
                // ProductNumber was null and CustomerID was not null
                if (request.Customer.CustomerID.Length >
                    customerIDFieldLength)
                {
                    Console.WriteLine("Error");
                }
            }
            else
            { // ProductNumber not null and CustomerID was null
                // Check Product Length
                if (request.CustomerProduct.ProductNumber.Length >
                    productFieldLength)
                {
                    Console.WriteLine("Error");
                }
            }
            // Set objects below with formatted data i.e PadLeft
            if (request.Customer.CustomerID != null)
            {
                request.Customer.CustomerID = request.Customer.CustomerID.PadLeft(
                    customerIDFieldLength,
                    Convert.ToChar("0", CultureInfo.CurrentCulture));
            }
            if (request.CustomerProduct.ProductNumber != null)
            {
                request.CustomerProduct.ProductNumber =
                    request.CustomerProduct.ProductNumber.PadLeft(
                        productFieldLength,
                        Convert.ToChar("0", CultureInfo.CurrentCulture));
            }
            return true;
        }
    }
}