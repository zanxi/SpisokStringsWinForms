using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpisokStringsWinForms
{
    public partial class AutorizationDBServer : Form
    {
        public bool connect = false;
        public AutorizationDBServer()
        {
            InitializeComponent();
            Load += AutorizationDBServer_Load;
        }

        private void AutorizationDBServer_Load(object sender, EventArgs e)
        {
            //SpisokStringsDB strDB = new SpisokStringsDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
