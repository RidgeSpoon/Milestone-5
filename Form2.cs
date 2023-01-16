using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mile_Stone_Inventory_Moving_List
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void butt1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string s = null;
            for (int i = 0; i <= 100; i++)
                s += rand.Next(0, 1001).ToString() + ",";
            MessageBox.Show(s);
        }

        private void butt2_Click(object sender, EventArgs e)
        {
            new Inventory().Show();
            this.Close();
        }
    }
}
