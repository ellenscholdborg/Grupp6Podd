
namespace Presentationslagret
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            lblLaggTillRss = new Label();
            textBoxRssLank = new TextBox();
            btnHamtaAvsnitt = new Button();
            listBoxAvsnitt = new ListBox();
            lblAvsnitt = new Label();
            lblGaTillAvsnitt = new Label();
            lblOmAvsnitt = new Label();
            comboBoxBytKategori = new ComboBox();
            btnTaBortKategori = new Button();
            rtbGaTillAvsnitt = new RichTextBox();
            rtbOmAvsnitt = new RichTextBox();
            lblMinaKategorier = new Label();
            listBoxKategori = new ListBox();
            btnSparaNyKategori = new Button();
            btnLaggTillKategori = new Button();
            lblAllaPoddfloden = new Label();
            listBoxAllaPoddfloden = new ListBox();
            btnTaBortPoddflode = new Button();
            btnSparaNyttNamn = new Button();
            btnLaggTillNyKategori = new Button();
            lblSkapaNyKategori = new Label();
            textBoxAngeNyKategori = new TextBox();
            richTextBoxLankTillPoddflode = new RichTextBox();
            lblLankTillPoddflode = new Label();
            textBoxAngeNyttNamnPodd = new TextBox();
            textBoxAndraNamnKategori = new TextBox();
            lblAngeNyttNamn = new Label();
            lblNyttNamnKategori = new Label();
            SuspendLayout();
            // 
            // lblLaggTillRss
            // 
            lblLaggTillRss.AutoSize = true;
            lblLaggTillRss.Location = new Point(12, 28);
            lblLaggTillRss.Name = "lblLaggTillRss";
            lblLaggTillRss.Size = new Size(134, 20);
            lblLaggTillRss.TabIndex = 0;
            lblLaggTillRss.Text = "Lägg in URL (RSS) :";
            // 
            // textBoxRssLank
            // 
            textBoxRssLank.Location = new Point(152, 25);
            textBoxRssLank.Name = "textBoxRssLank";
            textBoxRssLank.Size = new Size(260, 27);
            textBoxRssLank.TabIndex = 1;
            // 
            // btnHamtaAvsnitt
            // 
            btnHamtaAvsnitt.Location = new Point(12, 67);
            btnHamtaAvsnitt.Name = "btnHamtaAvsnitt";
            btnHamtaAvsnitt.Size = new Size(134, 29);
            btnHamtaAvsnitt.TabIndex = 2;
            btnHamtaAvsnitt.Text = "Hämta avsnitt";
            btnHamtaAvsnitt.UseVisualStyleBackColor = true;
            btnHamtaAvsnitt.Click += btnHamtaAvsnitt_Click_1;
            // 
            // listBoxAvsnitt
            // 
            listBoxAvsnitt.FormattingEnabled = true;
            listBoxAvsnitt.Location = new Point(12, 151);
            listBoxAvsnitt.Name = "listBoxAvsnitt";
            listBoxAvsnitt.Size = new Size(238, 264);
            listBoxAvsnitt.TabIndex = 3;
            listBoxAvsnitt.SelectedIndexChanged += listBoxAvsnitt_SelectedIndexChanged;
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(12, 110);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(57, 20);
            lblAvsnitt.TabIndex = 6;
            lblAvsnitt.Text = "Avsnitt:";
            // 
            // lblGaTillAvsnitt
            // 
            lblGaTillAvsnitt.AutoSize = true;
            lblGaTillAvsnitt.Location = new Point(272, 110);
            lblGaTillAvsnitt.Name = "lblGaTillAvsnitt";
            lblGaTillAvsnitt.Size = new Size(111, 20);
            lblGaTillAvsnitt.TabIndex = 7;
            lblGaTillAvsnitt.Text = "Gå till avsnittet:";
            // 
            // lblOmAvsnitt
            // 
            lblOmAvsnitt.AutoSize = true;
            lblOmAvsnitt.Location = new Point(490, 110);
            lblOmAvsnitt.Name = "lblOmAvsnitt";
            lblOmAvsnitt.Size = new Size(96, 20);
            lblOmAvsnitt.TabIndex = 8;
            lblOmAvsnitt.Text = "Om avsnittet:";
            // 
            // comboBoxBytKategori
            // 
            comboBoxBytKategori.FormattingEnabled = true;
            comboBoxBytKategori.Location = new Point(998, 535);
            comboBoxBytKategori.Name = "comboBoxBytKategori";
            comboBoxBytKategori.Size = new Size(151, 28);
            comboBoxBytKategori.TabIndex = 9;
            comboBoxBytKategori.Text = "Byt kategori";
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Location = new Point(296, 578);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(147, 30);
            btnTaBortKategori.TabIndex = 10;
            btnTaBortKategori.Text = "Ta bort kategori";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            btnTaBortKategori.Click += btnTaBortKategori_Click;
            // 
            // rtbGaTillAvsnitt
            // 
            rtbGaTillAvsnitt.Location = new Point(272, 151);
            rtbGaTillAvsnitt.Name = "rtbGaTillAvsnitt";
            rtbGaTillAvsnitt.Size = new Size(201, 264);
            rtbGaTillAvsnitt.TabIndex = 11;
            rtbGaTillAvsnitt.Text = "";
            // 
            // rtbOmAvsnitt
            // 
            rtbOmAvsnitt.Location = new Point(490, 151);
            rtbOmAvsnitt.Name = "rtbOmAvsnitt";
            rtbOmAvsnitt.Size = new Size(298, 264);
            rtbOmAvsnitt.TabIndex = 12;
            rtbOmAvsnitt.Text = "";
            rtbOmAvsnitt.TextChanged += richTextBox1_TextChanged;
            // 
            // lblMinaKategorier
            // 
            lblMinaKategorier.AutoSize = true;
            lblMinaKategorier.Location = new Point(12, 447);
            lblMinaKategorier.Name = "lblMinaKategorier";
            lblMinaKategorier.Size = new Size(117, 20);
            lblMinaKategorier.TabIndex = 13;
            lblMinaKategorier.Text = "Mina kategorier:";
            // 
            // listBoxKategori
            // 
            listBoxKategori.FormattingEnabled = true;
            listBoxKategori.Location = new Point(12, 470);
            listBoxKategori.Name = "listBoxKategori";
            listBoxKategori.Size = new Size(278, 304);
            listBoxKategori.TabIndex = 14;
            listBoxKategori.SelectedIndexChanged += listBoxKategori_SelectedIndexChanged;
            // 
            // btnSparaNyKategori
            // 
            btnSparaNyKategori.Location = new Point(541, 488);
            btnSparaNyKategori.Name = "btnSparaNyKategori";
            btnSparaNyKategori.Size = new Size(93, 28);
            btnSparaNyKategori.TabIndex = 15;
            btnSparaNyKategori.Text = "Spara";
            btnSparaNyKategori.UseVisualStyleBackColor = true;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Location = new Point(296, 531);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(147, 32);
            btnLaggTillKategori.TabIndex = 16;
            btnLaggTillKategori.Text = "Lägg till i kategori";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            // 
            // lblAllaPoddfloden
            // 
            lblAllaPoddfloden.AutoSize = true;
            lblAllaPoddfloden.Location = new Point(660, 447);
            lblAllaPoddfloden.Name = "lblAllaPoddfloden";
            lblAllaPoddfloden.Size = new Size(196, 20);
            lblAllaPoddfloden.TabIndex = 17;
            lblAllaPoddfloden.Text = "Alla poddflöden i kategorin:";
            // 
            // listBoxAllaPoddfloden
            // 
            listBoxAllaPoddfloden.FormattingEnabled = true;
            listBoxAllaPoddfloden.Location = new Point(660, 470);
            listBoxAllaPoddfloden.Name = "listBoxAllaPoddfloden";
            listBoxAllaPoddfloden.Size = new Size(323, 304);
            listBoxAllaPoddfloden.TabIndex = 18;
            // 
            // btnTaBortPoddflode
            // 
            btnTaBortPoddflode.Location = new Point(998, 579);
            btnTaBortPoddflode.Name = "btnTaBortPoddflode";
            btnTaBortPoddflode.Size = new Size(148, 29);
            btnTaBortPoddflode.TabIndex = 19;
            btnTaBortPoddflode.Text = "Ta bort poddflöde";
            btnTaBortPoddflode.UseVisualStyleBackColor = true;
            // 
            // btnSparaNyttNamn
            // 
            btnSparaNyttNamn.Location = new Point(1202, 487);
            btnSparaNyttNamn.Name = "btnSparaNyttNamn";
            btnSparaNyttNamn.Size = new Size(92, 29);
            btnSparaNyttNamn.TabIndex = 20;
            btnSparaNyttNamn.Text = "Spara";
            btnSparaNyttNamn.UseVisualStyleBackColor = true;
            // 
            // btnLaggTillNyKategori
            // 
            btnLaggTillNyKategori.Location = new Point(390, 797);
            btnLaggTillNyKategori.Name = "btnLaggTillNyKategori";
            btnLaggTillNyKategori.Size = new Size(94, 29);
            btnLaggTillNyKategori.TabIndex = 21;
            btnLaggTillNyKategori.Text = "Lägg till";
            btnLaggTillNyKategori.UseVisualStyleBackColor = true;
            btnLaggTillNyKategori.Click += btnLaggTillNyKategori_Click;
            // 
            // lblSkapaNyKategori
            // 
            lblSkapaNyKategori.AutoSize = true;
            lblSkapaNyKategori.Location = new Point(19, 801);
            lblSkapaNyKategori.Name = "lblSkapaNyKategori";
            lblSkapaNyKategori.Size = new Size(130, 20);
            lblSkapaNyKategori.TabIndex = 22;
            lblSkapaNyKategori.Text = "Skapa ny kategori:";
            // 
            // textBoxAngeNyKategori
            // 
            textBoxAngeNyKategori.Location = new Point(155, 798);
            textBoxAngeNyKategori.Name = "textBoxAngeNyKategori";
            textBoxAngeNyKategori.Size = new Size(217, 27);
            textBoxAngeNyKategori.TabIndex = 23;
            // 
            // richTextBoxLankTillPoddflode
            // 
            richTextBoxLankTillPoddflode.Location = new Point(1317, 470);
            richTextBoxLankTillPoddflode.Name = "richTextBoxLankTillPoddflode";
            richTextBoxLankTillPoddflode.Size = new Size(231, 304);
            richTextBoxLankTillPoddflode.TabIndex = 24;
            richTextBoxLankTillPoddflode.Text = "";
            // 
            // lblLankTillPoddflode
            // 
            lblLankTillPoddflode.AutoSize = true;
            lblLankTillPoddflode.Location = new Point(1317, 447);
            lblLankTillPoddflode.Name = "lblLankTillPoddflode";
            lblLankTillPoddflode.Size = new Size(138, 20);
            lblLankTillPoddflode.TabIndex = 25;
            lblLankTillPoddflode.Text = "Länk till poddflöde:";
            // 
            // textBoxAngeNyttNamnPodd
            // 
            textBoxAngeNyttNamnPodd.Location = new Point(998, 489);
            textBoxAngeNyttNamnPodd.Name = "textBoxAngeNyttNamnPodd";
            textBoxAngeNyttNamnPodd.Size = new Size(198, 27);
            textBoxAngeNyttNamnPodd.TabIndex = 26;
            // 
            // textBoxAndraNamnKategori
            // 
            textBoxAndraNamnKategori.Location = new Point(296, 489);
            textBoxAndraNamnKategori.Name = "textBoxAndraNamnKategori";
            textBoxAndraNamnKategori.Size = new Size(239, 27);
            textBoxAndraNamnKategori.TabIndex = 27;
            // 
            // lblAngeNyttNamn
            // 
            lblAngeNyttNamn.AutoSize = true;
            lblAngeNyttNamn.Location = new Point(998, 466);
            lblAngeNyttNamn.Name = "lblAngeNyttNamn";
            lblAngeNyttNamn.Size = new Size(213, 20);
            lblAngeNyttNamn.TabIndex = 28;
            lblAngeNyttNamn.Text = "Ange nytt namn på poddflöde:";
            // 
            // lblNyttNamnKategori
            // 
            lblNyttNamnKategori.AutoSize = true;
            lblNyttNamnKategori.Location = new Point(296, 466);
            lblNyttNamnKategori.Name = "lblNyttNamnKategori";
            lblNyttNamnKategori.Size = new Size(197, 20);
            lblNyttNamnKategori.TabIndex = 29;
            lblNyttNamnKategori.Text = "Ange nytt namn på kategori:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1579, 838);
            Controls.Add(lblNyttNamnKategori);
            Controls.Add(lblAngeNyttNamn);
            Controls.Add(textBoxAndraNamnKategori);
            Controls.Add(textBoxAngeNyttNamnPodd);
            Controls.Add(lblLankTillPoddflode);
            Controls.Add(richTextBoxLankTillPoddflode);
            Controls.Add(textBoxAngeNyKategori);
            Controls.Add(lblSkapaNyKategori);
            Controls.Add(btnLaggTillNyKategori);
            Controls.Add(btnSparaNyttNamn);
            Controls.Add(btnTaBortPoddflode);
            Controls.Add(listBoxAllaPoddfloden);
            Controls.Add(lblAllaPoddfloden);
            Controls.Add(btnLaggTillKategori);
            Controls.Add(btnSparaNyKategori);
            Controls.Add(listBoxKategori);
            Controls.Add(lblMinaKategorier);
            Controls.Add(rtbOmAvsnitt);
            Controls.Add(rtbGaTillAvsnitt);
            Controls.Add(btnTaBortKategori);
            Controls.Add(comboBoxBytKategori);
            Controls.Add(lblOmAvsnitt);
            Controls.Add(lblGaTillAvsnitt);
            Controls.Add(lblAvsnitt);
            Controls.Add(listBoxAvsnitt);
            Controls.Add(btnHamtaAvsnitt);
            Controls.Add(textBoxRssLank);
            Controls.Add(lblLaggTillRss);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Label lblLaggTillRss;
        private TextBox textBoxRssLank;
        private Button btnHamtaAvsnitt;
        private ListBox listBoxAvsnitt;
        private Label lblAvsnitt;
        private Label lblGaTillAvsnitt;
        private Label lblOmAvsnitt;
        private ComboBox comboBoxBytKategori;
        private Button btnTaBortKategori;
        private RichTextBox rtbGaTillAvsnitt;
        private RichTextBox rtbOmAvsnitt;
        private Label lblMinaKategorier;
        private ListBox listBoxKategori;
        private Button btnSparaNyKategori;
        private Button btnLaggTillKategori;
        private Label lblAllaPoddfloden;
        private ListBox listBoxAllaPoddfloden;
        private Button btnTaBortPoddflode;
        private Button btnSparaNyttNamn;
        private Button btnLaggTillNyKategori;
        private Label lblSkapaNyKategori;
        private TextBox textBoxAngeNyKategori;
        private RichTextBox richTextBoxLankTillPoddflode;
        private Label lblLankTillPoddflode;
        private TextBox textBoxAngeNyttNamnPodd;
        private TextBox textBoxAndraNamnKategori;
        private Label lblAngeNyttNamn;
        private Label lblNyttNamnKategori;
    }
}
