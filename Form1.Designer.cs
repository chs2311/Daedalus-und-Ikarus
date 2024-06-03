namespace Engine
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanelSplitter = new System.Windows.Forms.TableLayoutPanel();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.CoinsLabel = new System.Windows.Forms.Label();
            this.DamageLabel = new System.Windows.Forms.Label();
            this.ScenePanel = new System.Windows.Forms.Panel();
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Coin = new System.Windows.Forms.PictureBox();
            this.DeadlyLighthouse = new System.Windows.Forms.PictureBox();
            this.DeadlyBird = new System.Windows.Forms.PictureBox();
            this.PlayerHitbox = new System.Windows.Forms.PictureBox();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.TopPanel.SuspendLayout();
            this.TopPanelSplitter.SuspendLayout();
            this.ScenePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeadlyLighthouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeadlyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHitbox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.TopPanelSplitter);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 60);
            this.TopPanel.TabIndex = 0;
            // 
            // TopPanelSplitter
            // 
            this.TopPanelSplitter.ColumnCount = 3;
            this.TopPanelSplitter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopPanelSplitter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopPanelSplitter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopPanelSplitter.Controls.Add(this.ScoreLabel, 0, 0);
            this.TopPanelSplitter.Controls.Add(this.CoinsLabel, 1, 0);
            this.TopPanelSplitter.Controls.Add(this.DamageLabel, 2, 0);
            this.TopPanelSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanelSplitter.Location = new System.Drawing.Point(0, 0);
            this.TopPanelSplitter.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanelSplitter.Name = "TopPanelSplitter";
            this.TopPanelSplitter.RowCount = 1;
            this.TopPanelSplitter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopPanelSplitter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopPanelSplitter.Size = new System.Drawing.Size(798, 58);
            this.TopPanelSplitter.TabIndex = 0;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(3, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(260, 58);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score: 0";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CoinsLabel
            // 
            this.CoinsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoinsLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinsLabel.Location = new System.Drawing.Point(269, 0);
            this.CoinsLabel.Name = "CoinsLabel";
            this.CoinsLabel.Size = new System.Drawing.Size(260, 58);
            this.CoinsLabel.TabIndex = 1;
            this.CoinsLabel.Text = "Ges. Münzen: 0";
            this.CoinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DamageLabel
            // 
            this.DamageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DamageLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamageLabel.Location = new System.Drawing.Point(535, 0);
            this.DamageLabel.Name = "DamageLabel";
            this.DamageLabel.Size = new System.Drawing.Size(260, 58);
            this.DamageLabel.TabIndex = 2;
            this.DamageLabel.Text = "Beschädigt (%): 0";
            this.DamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScenePanel
            // 
            this.ScenePanel.BackColor = System.Drawing.Color.LightCyan;
            this.ScenePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScenePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScenePanel.Controls.Add(this.Coin3);
            this.ScenePanel.Controls.Add(this.Coin2);
            this.ScenePanel.Controls.Add(this.Coin);
            this.ScenePanel.Controls.Add(this.DeadlyLighthouse);
            this.ScenePanel.Controls.Add(this.DeadlyBird);
            this.ScenePanel.Controls.Add(this.PlayerHitbox);
            this.ScenePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScenePanel.Location = new System.Drawing.Point(0, 60);
            this.ScenePanel.Name = "ScenePanel";
            this.ScenePanel.Size = new System.Drawing.Size(800, 500);
            this.ScenePanel.TabIndex = 1;
            // 
            // Coin3
            // 
            this.Coin3.BackColor = System.Drawing.Color.Transparent;
            this.Coin3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Coin3.Location = new System.Drawing.Point(124, 31);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(16, 16);
            this.Coin3.TabIndex = 5;
            this.Coin3.TabStop = false;
            // 
            // Coin2
            // 
            this.Coin2.BackColor = System.Drawing.Color.Transparent;
            this.Coin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Coin2.Location = new System.Drawing.Point(391, 241);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(16, 16);
            this.Coin2.TabIndex = 4;
            this.Coin2.TabStop = false;
            // 
            // Coin
            // 
            this.Coin.BackColor = System.Drawing.Color.Transparent;
            this.Coin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Coin.Location = new System.Drawing.Point(500, 78);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(16, 16);
            this.Coin.TabIndex = 3;
            this.Coin.TabStop = false;
            // 
            // DeadlyLighthouse
            // 
            this.DeadlyLighthouse.BackColor = System.Drawing.Color.Transparent;
            this.DeadlyLighthouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeadlyLighthouse.Location = new System.Drawing.Point(512, 317);
            this.DeadlyLighthouse.Name = "DeadlyLighthouse";
            this.DeadlyLighthouse.Size = new System.Drawing.Size(80, 180);
            this.DeadlyLighthouse.TabIndex = 2;
            this.DeadlyLighthouse.TabStop = false;
            // 
            // DeadlyBird
            // 
            this.DeadlyBird.BackColor = System.Drawing.Color.Transparent;
            this.DeadlyBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeadlyBird.Location = new System.Drawing.Point(360, 157);
            this.DeadlyBird.Name = "DeadlyBird";
            this.DeadlyBird.Size = new System.Drawing.Size(35, 25);
            this.DeadlyBird.TabIndex = 1;
            this.DeadlyBird.TabStop = false;
            // 
            // PlayerHitbox
            // 
            this.PlayerHitbox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHitbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerHitbox.Location = new System.Drawing.Point(59, 146);
            this.PlayerHitbox.Name = "PlayerHitbox";
            this.PlayerHitbox.Size = new System.Drawing.Size(36, 36);
            this.PlayerHitbox.TabIndex = 0;
            this.PlayerHitbox.TabStop = false;
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 20;
            this.Clock.Tick += new System.EventHandler(this.Gameloop);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.ScenePanel);
            this.Controls.Add(this.TopPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daedalus und Ikarus Version 0.2";
            this.Load += new System.EventHandler(this.LoadAssets);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComputeInput);
            this.TopPanel.ResumeLayout(false);
            this.TopPanelSplitter.ResumeLayout(false);
            this.ScenePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeadlyLighthouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeadlyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHitbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ScenePanel;
        private System.Windows.Forms.TableLayoutPanel TopPanelSplitter;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label CoinsLabel;
        private System.Windows.Forms.Label DamageLabel;
        private System.Windows.Forms.PictureBox DeadlyLighthouse;
        private System.Windows.Forms.PictureBox DeadlyBird;
        private System.Windows.Forms.PictureBox PlayerHitbox;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.PictureBox Coin;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.PictureBox Coin2;
    }
}

