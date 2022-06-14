using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lonelyinteger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<int> arr = new List<int>() { 1, 2, 3, 4, 3, 2, 1 };
            Console.WriteLine(lonelyinteger(arr));
        }
        public static int lonelyinteger(List<int> a)
        {
            int donRepeat = 0;

            for (int i = 0; i < a.Count; i++)
            {
                int result = a.Count(f => f == a[i]);
                if(result == 1)
                {
                    donRepeat = a[i];
                    break;
                }

            }
            return donRepeat;
        }

    }
}
