namespace KesaHarjoitus1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LabelEsimerkki = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NumeerinenYA = new System.Windows.Forms.NumericUpDown();
            this.aValinta1 = new System.Windows.Forms.CheckBox();
            this.aNappi1 = new System.Windows.Forms.Button();
            this.aOmaSelain = new System.Windows.Forms.WebBrowser();
            this.aOsoiteRivi = new System.Windows.Forms.TextBox();
            this.aEdistymispalkki = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.näytäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.NumeerinenYA)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelEsimerkki
            // 
            this.LabelEsimerkki.AutoSize = true;
            this.LabelEsimerkki.Location = new System.Drawing.Point(175, 125);
            this.LabelEsimerkki.Name = "LabelEsimerkki";
            this.LabelEsimerkki.Size = new System.Drawing.Size(93, 13);
            this.LabelEsimerkki.TabIndex = 0;
            this.LabelEsimerkki.Text = "Tämä on testilabel";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NumeerinenYA
            // 
            this.NumeerinenYA.Location = new System.Drawing.Point(81, 62);
            this.NumeerinenYA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumeerinenYA.Name = "NumeerinenYA";
            this.NumeerinenYA.Size = new System.Drawing.Size(120, 20);
            this.NumeerinenYA.TabIndex = 1;
            this.NumeerinenYA.ValueChanged += new System.EventHandler(this.NumeerinenYA_ValueChanged);
            // 
            // aValinta1
            // 
            this.aValinta1.AutoSize = true;
            this.aValinta1.Location = new System.Drawing.Point(81, 185);
            this.aValinta1.Name = "aValinta1";
            this.aValinta1.Size = new System.Drawing.Size(42, 17);
            this.aValinta1.TabIndex = 2;
            this.aValinta1.Text = "Yo!";
            this.aValinta1.UseVisualStyleBackColor = true;
            this.aValinta1.UseWaitCursor = true;
            this.aValinta1.CheckedChanged += new System.EventHandler(this.aValinta1_CheckedChanged);
            // 
            // aNappi1
            // 
            this.aNappi1.Location = new System.Drawing.Point(81, 225);
            this.aNappi1.Name = "aNappi1";
            this.aNappi1.Size = new System.Drawing.Size(75, 23);
            this.aNappi1.TabIndex = 3;
            this.aNappi1.Text = "Paina minua";
            this.aNappi1.UseVisualStyleBackColor = true;
            this.aNappi1.Click += new System.EventHandler(this.aNappi1_Click);
            // 
            // aOmaSelain
            // 
            this.aOmaSelain.Location = new System.Drawing.Point(386, 77);
            this.aOmaSelain.MinimumSize = new System.Drawing.Size(20, 20);
            this.aOmaSelain.Name = "aOmaSelain";
            this.aOmaSelain.Size = new System.Drawing.Size(464, 438);
            this.aOmaSelain.TabIndex = 4;
            this.aOmaSelain.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            // 
            // aOsoiteRivi
            // 
            this.aOsoiteRivi.Location = new System.Drawing.Point(386, 27);
            this.aOsoiteRivi.Name = "aOsoiteRivi";
            this.aOsoiteRivi.Size = new System.Drawing.Size(464, 20);
            this.aOsoiteRivi.TabIndex = 5;
            this.aOsoiteRivi.TextChanged += new System.EventHandler(this.aOsoiteRivi_TextChanged);
            // 
            // aEdistymispalkki
            // 
            this.aEdistymispalkki.Location = new System.Drawing.Point(81, 279);
            this.aEdistymispalkki.Name = "aEdistymispalkki";
            this.aEdistymispalkki.Size = new System.Drawing.Size(223, 23);
            this.aEdistymispalkki.Step = 1;
            this.aEdistymispalkki.TabIndex = 6;
            this.aEdistymispalkki.Value = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.näytäToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaaToolStripMenuItem,
            this.poistuToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // näytäToolStripMenuItem
            // 
            this.näytäToolStripMenuItem.Name = "näytäToolStripMenuItem";
            this.näytäToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.näytäToolStripMenuItem.Text = "Näytä";
            // 
            // avaaToolStripMenuItem
            // 
            this.avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            this.avaaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.avaaToolStripMenuItem.Text = "Avaa";
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 563);
            this.Controls.Add(this.aEdistymispalkki);
            this.Controls.Add(this.aOsoiteRivi);
            this.Controls.Add(this.aOmaSelain);
            this.Controls.Add(this.aNappi1);
            this.Controls.Add(this.aValinta1);
            this.Controls.Add(this.NumeerinenYA);
            this.Controls.Add(this.LabelEsimerkki);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumeerinenYA)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelEsimerkki;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown NumeerinenYA;
        private System.Windows.Forms.CheckBox aValinta1;
        private System.Windows.Forms.Button aNappi1;
        private System.Windows.Forms.WebBrowser aOmaSelain;
        private System.Windows.Forms.TextBox aOsoiteRivi;
        private System.Windows.Forms.ProgressBar aEdistymispalkki;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem näytäToolStripMenuItem;
    }
}

