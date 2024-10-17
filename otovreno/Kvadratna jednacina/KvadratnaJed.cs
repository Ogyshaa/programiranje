using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvadradtna_jed
{
    internal class KvadratnaJed
    {
        private double a, b, c, x1, x2, d;
        double re, im;
        string r1,r2;
        public double A
        {
            get { return a; }
            set { a = value; }
            //obj.A=value;
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public KvadratnaJed(double x, double y, double c)
        {
            a = x;
            b = y;
            this.c = c;
        }

        public void KvadradtnaJed()
        {
            a = 0;b= 0;c = 0;
        }

        public void RealnaDvo()
        {
            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c));
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c));
        }
        public void RealnaRaz()
        {
            x1 = -b / (2 * a);
            
        }

        public void KonjKomp()
        {
            re =Math.Round( -b / (2 * a),2);
      
            im = Math.Round(Math.Sqrt(-d) / (2 * a),2);
            r1 = re + "+i*" + im;
            r2 = re + "-i*" + im;
        }
        public string Diskriminatna()
        {
            d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0) { //2 realna racun
                RealnaDvo();
                return "Jednacina ima dvostruko realna resenja:" + Math.Round(x1, 2) +Math.Round(x2,2); }
            else
                if (d == 0){
                RealnaRaz(); 
                return "Jednacina ima jedno realno resenje:"+ Math.Round(x1, 2); }
            else
            {
                KonjKomp();
                return "Jednacina ima dva konjugovana komoleksna resenja\r\n" +r1 + Environment.NewLine + r2; }
        }
    }
}