using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine
{
    public partial class Form1 : Form
    {
        public int Damage = 0;
        public int Coins = 0;
        public int Score = 0;

        public float PY = 120;
        public float BY = 130;

        public Form1()
        {
            new Tutorial().ShowDialog();
            InitializeComponent();
        }

        private void LoadAssets(object sender, EventArgs e)
        {
            //ScenePanel.BackgroundImage = Image.FromFile("364F831336E7135115B20427CA31F2C610AE8348691BF2F10D583E47FD77D235\\ocean RS\\0");
            PlayerHitbox.BackgroundImage = Image.FromFile("790C04D6C5519261178A51F0A7C946FC13FAA11C6F822234B384861BEF363234\\person\\0");
            DeadlyLighthouse.BackgroundImage = Image.FromFile("70FAE40B0F0629C344E63442A19B839E0BA88682FD9CE7AA0A8F9C139E3BF723\\lighthouse\\0");
            DeadlyBird.BackgroundImage = Image.FromFile("EFE7D9D81DF727693108F44E9FD32F5D7BD8C12E73FAC34A5D75630E883EE019\\bird\\0");
            Coin.BackgroundImage = Image.FromFile("2B11E76391EB56D8404F8762011FC1C52C4EC971C82B5AC3814974857655B1BE\\coin\\0");
            Coin2.BackgroundImage = Image.FromFile("2B11E76391EB56D8404F8762011FC1C52C4EC971C82B5AC3814974857655B1BE\\coin\\2");
            Coin3.BackgroundImage = Image.FromFile("2B11E76391EB56D8404F8762011FC1C52C4EC971C82B5AC3814974857655B1BE\\coin\\3");

            Coin.Top = 100 + (new Random().Next(0, 150));
            Coin2.Top = 100 + (new Random().Next(0, 150));
            Coin3.Top = 100 + (new Random().Next(0, 150));
        }

        private void ComputeInput(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                PY -= 2.5F;
            }
            if(e.KeyCode == Keys.Escape)
            {
                Clock.Enabled = !Clock.Enabled;
            }
            if (e.KeyCode == Keys.C)
            {
                PY += 5F;
            }
            if (e.KeyCode == Keys.M)
            {
                PY = 120;
                BY = 130;
                Clock.Enabled = false;
                DeadlyLighthouse.Left = 512;
                DeadlyBird.Left = 360;
                Damage = 0;
                Coins = 0;
                Score = 0;
                LoadAssets(null, null);
                Clock.Enabled = true;
            }
        }

        private void Gameloop(object sender, EventArgs e)
        {
            UpdateGravity();
            UpdateDamage();
            UpdateLabels();
            UpdateCoins();
            UpdateBird();
            UpdateLighthouse();
        }

        public void UpdateCoins()
        {
            PictureBox[] coins = new PictureBox[] { Coin, Coin2, Coin3 };

            foreach (PictureBox c in coins)
            {
                c.Left -= (new Random()).Next(0, 5);

                if(PlayerHitbox.Bounds.IntersectsWith(c.Bounds))
                {
                    c.Left = -25;
                    Coins++;
                    Score += 120;
                }

                if(c.Left < -25)
                {
                    c.Left = 300 + (new Random().Next(0, 500));
                    c.Top = 100 + (new Random().Next(0, 200));
                }
            }
        }

        public void UpdateLighthouse()
        {
            DeadlyLighthouse.Left--;

            if(DeadlyLighthouse.Left < -90)
            {
                DeadlyLighthouse.Left = 500 + (new Random().Next(0, 300));
                Score += 1000;
            }
        }

        public void UpdateGravity()
        {
            PY += 0.4F + Damage / 25;
            PlayerHitbox.Top = (int)PY;
        }

        public void UpdateBird()
        {
            BY += new Random().Next(-1, 2);
            DeadlyBird.Top = (DeadlyBird.Top + 2 * (int)BY) / 3;
            DeadlyBird.Left--;

            if(DeadlyBird.Left < -20)
            {
                DeadlyBird.Left = 300 + (new Random().Next(0, 500));
                Score += 600;
            }
        }

        private void UpdateDamage()
        {
            if(PlayerHitbox.Bounds.IntersectsWith(DeadlyBird.Bounds))
            {
                Damage += 20;
                DeadlyBird.Left = -30;
            }

            if (PlayerHitbox.Bounds.IntersectsWith(DeadlyLighthouse.Bounds))
            {
                Damage += 63;
                DeadlyLighthouse.Left = -90;
            }

            if (PY < 50)
            {
                Damage++;

                if (Damage >= 100)
                {
                    Damage = 100;
                }
            }
            if (PY > 355)
            {
                Damage += 10;

                if (Damage >= 100)
                {
                    Damage = 100;
                }
            }

            if (Damage >= 100)
            {
                Clock.Enabled = false;
                UpdateLabels();
                MessageBox.Show("Du hast zu viel Schaden genommen!", "Game over !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Tutorial().ShowDialog();
            }
        }

        private void UpdateLabels()
        {
            ScoreLabel.Text = "Score: " + Score;
            CoinsLabel.Text = "Münzen: " + Coins;
            DamageLabel.Text = "Beschädigt (%): " + Damage;

            if(Damage >= 70)
            {
                DamageLabel.ForeColor = Color.Red;
            }
            else if (Damage >= 50)
            {
                DamageLabel.ForeColor = Color.Yellow;
            }
            else
            {
                DamageLabel.ForeColor = SystemColors.ControlText;
            }
        }
    }
}
