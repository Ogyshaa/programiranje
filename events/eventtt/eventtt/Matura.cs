using System;
using System.Windows.Forms;

namespace eventtt
{
    public class Matura : EventArgs
    {
        private string message;

        public Matura(string poruka)
        {
            message = poruka;
        }

        public string Message
        {
            get { return message; }
        }
    }

    public class MaturskiIspit
    {
        private int srpski, test, praksa;

        public delegate void MaturaHandler(object sender, Matura e);
        public event MaturaHandler OhrNour;

        public int Srpski
        {
            set
            {
                srpski = value;
                if (srpski == 1)
                {
                    Matura e = new Matura("👍 Odlično odrađeno! Sedi jedan :)");
                    OhrNour?.Invoke(this, e);
                }
            }
        }

        public int Test
        {
            set
            {
                test = value;
                if (test == 1)
                {
                    Matura e = new Matura("👍 Odlično odrađeno! Sedi jedan :)");
                    OhrNour?.Invoke(this, e);
                }
            }
        }

        public int Praksa
        {
            set
            {
                praksa = value;
                if (praksa == 1)
                {
                    Matura e = new Matura("👍 Odlično odrađeno! Sedi jedan :)");
                    OhrNour?.Invoke(this, e);
                }
            }
        }
    }

    public class MaturaMonitor
    {
        public MaturaMonitor(MaturskiIspit matura)
        {
            matura.OhrNour += PrikazPoruku;
        }

        public void PrikazPoruku(object sender, Matura e)
        {
            MessageBox.Show(e.Message);
        }
    }
}
