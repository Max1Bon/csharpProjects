using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Melody
{
    public partial class fGame : Form
    {
        Random rnd = new Random();
        int musicDuration=Viktorina.musicDuration;

        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if (Viktorina.list.Count == 0) EndGame();
            else
            {
                musicDuration = Viktorina.musicDuration;
                int n = rnd.Next(0, Viktorina.list.Count); //случайная песня
                wmp.URL = Viktorina.list[n]; //эта песня в прогрывателе
                                             //wmp.Ctlcontrols.play(); //если пллер не воспроизводит
                Viktorina.list.RemoveAt(n); //удалить композицию из списка
                lblMelodyCount.Text = Viktorina.list.Count.ToString(); //загружатся количество оставшихся на проигрывание песен
            }
            }


        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            wmp.Ctlcontrols.pause();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            wmp.Ctlcontrols.play();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            wmp.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblMelodyCount.Text = Viktorina.list.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            lblMusicDuration.Text = Viktorina.gameDuration.ToString();
            progressBar1.Maximum = Viktorina.gameDuration;
            lblMusicDuration.Text = musicDuration.ToString();
        }

        void EndGame() //when time is limitted, music to stop
        {
            timer1.Stop();
            wmp.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            lblMusicDuration.Text = musicDuration.ToString();
            if (progressBar1.Value==progressBar1.Maximum)
            {
                EndGame();
                return; //exit function
            }
            if (musicDuration == 0) MakeMusic();
        }
        // This function make to pause game
        void GamePause()
        {
            timer1.Stop();
            wmp.Ctlcontrols.pause();
        }

        // This function make to play game
        void GamePlay()
        {
            timer1.Start();
            wmp.Ctlcontrols.play();
        }

        //if key "A" is ON then... or if key "A" is OFF then...
        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {   //player 1
            if (e.KeyData==Keys.A)
            {

                fMessage fm = new fMessage();
                fm.lblMessage.Text = "Игрок 1";
                GamePause();
                SoundPlayer sp = new SoundPlayer("res\\uno.wav");
                sp.PlaySync();
                if(fm.ShowDialog() == DialogResult.Yes) //if player had true answer then..
                {
                    lblCounter1.Text = Convert.ToString(Convert.ToInt32(lblCounter1.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
            
            //player 2
            if (e.KeyData == Keys.K)
            {
                GamePause();
                fMessage fm = new fMessage();
                fm.lblMessage.Text = "Игрок 2";
                GamePause();
                SoundPlayer sp = new SoundPlayer("res\\dos.wav");
                sp.PlaySync();
                if (fm.ShowDialog() == DialogResult.Yes) //if player had true answer then..
                {
                    lblCounter2.Text = Convert.ToString(Convert.ToInt32(lblCounter2.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }

        private void wmp_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            //play music from rnd position
            if (Viktorina.randomeStart)
            if (wmp.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    wmp.Ctlcontrols.currentPosition = rnd.Next(0, (int)wmp.currentMedia.duration / 2);
            
        }
    }
}
