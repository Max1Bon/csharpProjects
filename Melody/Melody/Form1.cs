using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melody
{
    public partial class fMenu : Form
    {
        fParam fp = new fParam();
        fGame fg = new fGame();

        public fMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParam_Click(object sender, EventArgs e)
        {
            
            fp.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            fg.ShowDialog();
        }

        private void fMenu_Load(object sender, EventArgs e)
        {
            Viktorina.ReadParam();
            Viktorina.ReadMusic();
        }
    }
}
