using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ClassHelper
{
    internal class EF
    {
        public static DB.VehicleRentEntities Context { get; } = new DB.VehicleRentEntities();
    }
}
