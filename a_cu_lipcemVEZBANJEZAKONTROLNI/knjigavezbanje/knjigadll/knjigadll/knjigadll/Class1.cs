using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace knjigadll
{
    public static class LBox
    {
        public static void PrikaziLB(ListBox lb,List<string> ls)
        {
            lb.Items.Clear();
            foreach (string s in ls)
                lb.Items.Add(s);
        }
        public static  int LBSelIndex(ListBox lb)
        {
            return lb.SelectedIndex;
        }
    }
}
