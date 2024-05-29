using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPerson
{
    public class Person
    {
        // address
        public string StreetAddress, Postcode, City;
        // employment info
        public string CompanyName, Position;
        public int AnnualIncome;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Address: {StreetAddress}, {Postcode}, {City}\n");
            sb.Append($"Employed at {CompanyName} as a {Position} earning {AnnualIncome}");
            return sb.ToString();
        }
    }   
}
