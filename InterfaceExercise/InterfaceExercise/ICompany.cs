using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string CompanyName { get; set; }
        public int NumberOfYearsAsATopTen { get; set; }
        public string Logo { get; set; }
        public string Motto { get; set; }

        public void DisplayInformation();
    }
}
