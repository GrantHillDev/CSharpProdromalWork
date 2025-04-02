using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string companyName { get; set; }
        public int numberOfYearsAsATopTen { get; set; }
        public string logo { get; set; }
        public string motto { get; set; }

        public void DisplayInformation();
    }
}
