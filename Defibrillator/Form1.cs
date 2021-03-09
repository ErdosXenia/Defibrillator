using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defibrillator
{
    public partial class frmKeszulek : Form
    {
        List<Keszulek> keszulekek = new List<Keszulek>();

        public frmKeszulek()
        {
            InitializeComponent();
        }

        private void btnAdatok_Click(object sender, EventArgs e)
        {

            try
            {
                StreamReader sr = new StreamReader("data.csv");
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] a = sr.ReadLine().Split(';');
                    keszulekek.Add(new Keszulek(Convert.ToInt32(a[0]), a[1], Convert.ToDouble(a[2]), Convert.ToDouble(a[3]), a[4], a[5]));
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
