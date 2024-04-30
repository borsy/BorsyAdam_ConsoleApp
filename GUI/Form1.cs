using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        List<Dolgozo> dolgozok = new List<Dolgozo>();
        Adatbazis_kapcsolat adat = new Adatbazis_kapcsolat();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista_frissitese();
        }

        private void lista_frissitese()
        {
            listBox_dolgozok.Items.Clear();
            dolgozok = adat.getAllDolgozo();
        }
    }
}
