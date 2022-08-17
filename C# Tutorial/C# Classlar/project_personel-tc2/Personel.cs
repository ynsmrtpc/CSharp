using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_personel_tc2
{
    class Personel
    {
        private string tc;

        public string TC
        {
            get
            {
                return this.TC.Substring(0, 4);
            }

            set
            {
                bool control = false;

                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayi_mi = char.IsNumber(value[i]);

                        if (!sayi_mi)
                        {
                            control = true;
                            break;
                        }
                    }
                    if (control)
                    {
                        Console.WriteLine("TC kimlik numarası harf içeremez.");
                    }
                    else
                    {
                        TC = value;
                    }

                }
                else
                {
                    Console.WriteLine("TC kimlik numarası 11 haneli olmalıdır.");
                }
            }
        }
    }
}
