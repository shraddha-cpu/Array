using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayCourse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }

        public override string ToString()
        {
            return $"Product details : {Id}  {Name}  {Fees}";
        }

    }
}
