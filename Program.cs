using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace ListPractice
{
    class CompanyData : IEquatable<CompanyData>
    {
        public int Profit { get; set; }
        public string CompanyName { get; set; }
        public int NetFixedAssets { get; set; }

        public override string ToString()
        {
            return "CompanyName: " + CompanyName + "   Profit: " + Profit;
        }


        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            CompanyData objAsPart = obj as CompanyData;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
  //     public override string GetHashCode()
   //     {
//            return CompanyName;
 //       }
        public bool Equals(CompanyData other)
        {
            if (other == null) return false;
            return (this.CompanyName.Equals(other.CompanyName));
        }

        static void Main(string[] args)
        {

            List<CompanyData> Companies = new List<CompanyData>();

            // Add parts to the list.
            Companies.Add(new CompanyData() { CompanyName = "Unilever ", Profit = 3321 });
            Companies.Add(new CompanyData() { CompanyName = "JP Morgan ", Profit = 6432 });
            Companies.Add(new CompanyData() { CompanyName = "AstraZeneca ", Profit = 6531 });
            Companies.Add(new CompanyData() { CompanyName = "Experian ", Profit = 1444 });
            Companies.Add(new CompanyData() { CompanyName = "Ideagen ", Profit = 353 });
            Companies.Add(new CompanyData() { CompanyName = "Bobs Factory ", Profit = -342 });

            for (int i = 0; i < Companies.Count; i++)
            {
                Console.WriteLine($"Before Addition we have Company: " + Companies[i].CompanyName + "Profit: " + Companies[i].Profit);
            }

            //Add a new company
            string NewCompany = "Philip Morris International";
            Companies.Add(new CompanyData() { CompanyName = NewCompany, Profit = 33 });

            //List companies after addition
            for (int i = 0; i < Companies.Count; i++)
            {
                Console.WriteLine($"After Addition we have Company: " + Companies[i].CompanyName + "Profit: " + Companies[i].Profit);
            }

            //Remove NewCompany
            Companies.Remove(new CompanyData() { CompanyName = NewCompany });

            //List companies after removal (option 1)
            for (int i = 0; i < Companies.Count; i++)
            {
                Console.WriteLine($"After Removal we have Company: " + Companies[i].CompanyName + "Profit: " + Companies[i].Profit);
            }

            //List companies after removal (option 2, calls the public override string)
            foreach (CompanyData elements in Companies)   
            {
                Console.WriteLine($"Final List: " + elements);
            }

            //Check whether a particular company is present
            Console.WriteLine("\nContains(\"Unilever\"): {0}",
            Companies.Contains(new CompanyData { Profit = 0, CompanyName = "Unilever" }));
        }
    }
}

