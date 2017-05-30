using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Speck
    {
        private Guid _identifier;
        public Guid ID
        {
            get { return _identifier; }
            set { _identifier = value; }
        }

        public int Classification { get; set; }
    }
}
