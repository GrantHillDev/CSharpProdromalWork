using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public interface IDataAccess//accessing the same data, but from different databases. This is a display of how a program can benefit from the flexibility of factory patterned programing; rather than writing out the same data from each database for each database type, the static factory class can any of them through singular script, that's written with versatility.
    {
        public void SaveData();
        public List<Product> LoadData();
    }
}
