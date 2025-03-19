using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Polimorf
{
    class Figura
    {
        protected int a;

        public Figura(int a)
        {
            this.a = a;
        }

        virtual public void CrtajFig(Graphics g,int x, int y)
        {

        }
    }
    class Krug : Figura
    {
        public Krug(int a) : base(a)
        {

        }
        public override void CrtajFig(Graphics g, int x, int y)
        {
            Brush cetkaj_me = new SolidBrush(Color.Red);
            g.FillEllipse(cetkaj_me, x, y, a, a);
            return;
        }
        public string Prikazi1()
        {
            return "Krug precnoka " + a.ToString();
        }
    }
    class Kvadrat : Figura
    {
        public Kvadrat(int a): base(a)
        {

        }
        public override void CrtajFig(Graphics g, int x, int y)
        {
            Brush cetkaj_me = new SolidBrush(Color.Olive);
            g.FillRectangle(cetkaj_me, x, y, a, a);
            return;
        }
        public string Prikazi()
        {
            return "Kvadrata stranica " + a.ToString();
        }
    }
}
