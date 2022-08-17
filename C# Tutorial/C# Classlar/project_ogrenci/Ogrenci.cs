using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ogrenci
{
    class Ogrenci
    {
        private double ogrenci_no;
        private string isim;
        private string soyisim;
        private int vize_1;
        private int vize_2;
        private int final;
        private string okul_ismi;

        public Ogrenci(int ogrenci_no, string isim, string soyisim, int vize_1, int vize_2, int final, string okul_ismi)
        {
            this.ogrenci_no = ogrenci_no;
            this.isim = isim;
            this.soyisim = soyisim;
            this.vize_1 = vize_1;
            this.vize_2 = vize_2;
            this.final = final;
            this.okul_ismi = okul_ismi;
        }

        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("\n****** Öğrenci Bilgileri\n");
            Console.WriteLine("İsim: {0}\nSoyisim: {1}\nOgrenci No: {2}\n1. Vize Notu: {3}\n2. Vize Notu: {4}\nFinal Notu: {5}\nOkul İsmi:{6}", this.isim, this.soyisim, this.ogrenci_no,this.vize_1,this.vize_2,this.final,this.okul_ismi);
        }

        public double ogrenciOrt_bul()
        {
            double ogrenci_ort = ((this.vize_1) * 0.20 + (this.vize_2) * 0.20 + (this.final) * 0.60);
            return ogrenci_ort;
        }

        public string okulGetir()
        {
            return this.okul_ismi;
        }

    }
}
