using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like1C
{
    public class Subject
    {
        private int Id { get; set; }
        public TypeOfSubject type { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public static TypeOfSubject Type { get; internal set; }

        public override string ToString()
        {
            return String.Format("{0} Name - {1}, Ammount - {2}", type, Name, Count);
        }
    }
}
