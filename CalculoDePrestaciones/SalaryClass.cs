using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDePrestaciones
{
    public class SalaryClass
    {

        public decimal salary { get; set; }
        public decimal comission { get; set; }
        public decimal totals { get; set; }

        public decimal getTotals(decimal _totals)
        {
            totals = _totals;

            return totals;
        }

    }
}
