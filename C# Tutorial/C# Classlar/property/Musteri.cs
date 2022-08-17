using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    class Musteri
    {
        private long tc;
        private int yas;

        public int Yas { get ; set; }

        public long Tc {

            get
            {
                 return tc;
            }

            set
            {
                tc = value;
            }
        
        
        }
    }
}
