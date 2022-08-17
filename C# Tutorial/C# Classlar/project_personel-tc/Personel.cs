using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_personel_tc
{
    class Personel
    {
        private string tc;
        public string TC 
        {
            get
            {
                return TC.Substring(0, 4);
            }

            set
            {
                bool kontrol = false;

                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool SayiMi = char.IsNumber(value[i]);

                        if (!SayiMi)
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("TC kimlik numarası sayılardan oluşmalıdır.");
                    }
                    else
                    {
                        this.TC = value;
                    }
                }
                else
                    Console.WriteLine("TC kimlik numarası 11 haneli olmalıdır!");
            } 
        }
    }
}
