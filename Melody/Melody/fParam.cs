using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Melody
{
    public partial class fParam : Form
    {
        public fParam()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {//Запись в реестор
            Viktorina.allDirectories = cbAllDirect.Checked;
            Viktorina.gameDuration = Convert.ToInt32(cbGameDuration.Text);
            Viktorina.musicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Viktorina.randomeStart = cbRandomStart.Checked;
            Viktorina.WriteParam(); 
            this.Hide();
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {//выбор музыки
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] musicList = Directory.GetFiles(fbd.SelectedPath, "*.mp3", cbAllDirect.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                Viktorina.lastFolder = fbd.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(musicList);
                Viktorina.list.Clear();
                Viktorina.list.AddRange(musicList);
            }
        }

        void Set()
        {
            cbAllDirect.Checked = Viktorina.allDirectories;
            cbGameDuration.Text = Viktorina.gameDuration.ToString();     //забираем параметры 
            cbMusicDuration.Text = Viktorina.musicDuration.ToString();
            cbRandomStart.Checked = Viktorina.randomeStart;
        }
        private void fParam_Load(object sender, EventArgs e)
        {
            Set();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Viktorina.list.ToArray());
        }
    }
}
