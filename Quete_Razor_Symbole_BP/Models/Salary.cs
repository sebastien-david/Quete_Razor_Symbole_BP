using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quete_Razor_Symbole_BP.Models
{
    public class Salary
    {

        public int Amount { get; set; }
        public Salary(int amount)
        {

            Amount = amount;
        }
    }
}
