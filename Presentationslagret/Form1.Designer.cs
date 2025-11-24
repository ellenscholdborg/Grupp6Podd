
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
            btnSparaBytKategori = new Button();
            SuspendLayout();
            // 
            // lblLaggTillRss
            // 
            lblLaggTillRss.AutoSize = true;
            lblLaggTillRss.Location = new Point(15, 35);
            lblLaggTillRss.Margin = new Padding(4, 0, 4, 0);
            lblLaggTillRss.Name = "lblLaggTillRss";
            lblLaggTillRss.Size = new Size(161, 25);
            lblLaggTillRss.TabIndex = 0;
            lblLaggTillRss.Text = "Lägg in URL (RSS) :";
            // 
            // textBoxRssLank
            // 
            textBoxRssLank.Location = new Point(190, 31);
            textBoxRssLank.Margin = new Padding(4);
            textBoxRssLank.Name = "textBoxRssLank";
            textBoxRssLank.Size = new Size(324, 31);
            textBoxRssLank.TabIndex = 1;
            // 
            // btnHamtaAvsnitt
            // 
            btnHamtaAvsnitt.Location = new Point(15, 84);
            btnHamtaAvsnitt.Margin = new Padding(4);
            btnHamtaAvsnitt.Name = "btnHamtaAvsnitt";
            btnHamtaAvsnitt.Size = new Size(168, 36);
            btnHamtaAvsnitt.TabIndex = 2;
            btnHamtaAvsnitt.Text = "Hämta avsnitt";
            btnHamtaAvsnitt.UseVisualStyleBackColor = true;
            btnHamtaAvsnitt.Click += btnHamtaAvsnitt_Click_1;
            // 
            // listBoxAvsnitt
            // 
            listBoxAvsnitt.FormattingEnabled = true;
            listBoxAvsnitt.Location = new Point(15, 189);
            listBoxAvsnitt.Margin = new Padding(4);
            listBoxAvsnitt.Name = "listBoxAvsnitt";
            listBoxAvsnitt.Size = new Size(296, 329);
            listBoxAvsnitt.TabIndex = 3;
            listBoxAvsnitt.SelectedIndexChanged += listBoxAvsnitt_SelectedIndexChanged;
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(15, 138);
            lblAvsnitt.Margin = new Padding(4, 0, 4, 0);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(71, 25);
            lblAvsnitt.TabIndex = 6;
            lblAvsnitt.Text = "Avsnitt:";
            // 
            // lblGaTillAvsnitt
            // 
            lblGaTillAvsnitt.AutoSize = true;
            lblGaTillAvsnitt.Location = new Point(340, 138);
            lblGaTillAvsnitt.Margin = new Padding(4, 0, 4, 0);
            lblGaTillAvsnitt.Name = "lblGaTillAvsnitt";
            lblGaTillAvsnitt.Size = new Size(132, 25);
            lblGaTillAvsnitt.TabIndex = 7;
            lblGaTillAvsnitt.Text = "Gå till avsnittet:";
            // 
            // lblOmAvsnitt
            // 
            lblOmAvsnitt.AutoSize = true;
            lblOmAvsnitt.Location = new Point(612, 138);
            lblOmAvsnitt.Margin = new Padding(4, 0, 4, 0);
            lblOmAvsnitt.Name = "lblOmAvsnitt";
            lblOmAvsnitt.Size = new Size(118, 25);
            lblOmAvsnitt.TabIndex = 8;
            lblOmAvsnitt.Text = "Om avsnittet:";
            // 
            // comboBoxBytKategori
            // 
            comboBoxBytKategori.FormattingEnabled = true;
            comboBoxBytKategori.Location = new Point(1248, 669);
            comboBoxBytKategori.Margin = new Padding(4);
            comboBoxBytKategori.Name = "comboBoxBytKategori";
            comboBoxBytKategori.Size = new Size(188, 33);
            comboBoxBytKategori.TabIndex = 9;
            comboBoxBytKategori.Text = "Byt kategori";
            comboBoxBytKategori.SelectedIndexChanged += comboBoxBytKategori_SelectedIndexChanged;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Location = new Point(370, 722);
            btnTaBortKategori.Margin = new Padding(4);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(184, 38);
            btnTaBortKategori.TabIndex = 10;
            btnTaBortKategori.Text = "Ta bort kategori";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            btnTaBortKategori.Click += btnTaBortKategori_Click;
            // 
            // rtbGaTillAvsnitt
            // 
            rtbGaTillAvsnitt.Location = new Point(340, 189);
            rtbGaTillAvsnitt.Margin = new Padding(4);
            rtbGaTillAvsnitt.Name = "rtbGaTillAvsnitt";
            rtbGaTillAvsnitt.Size = new Size(250, 329);
            rtbGaTillAvsnitt.TabIndex = 11;
            rtbGaTillAvsnitt.Text = "";
            // 
            // rtbOmAvsnitt
            // 
            rtbOmAvsnitt.Location = new Point(612, 189);
            rtbOmAvsnitt.Margin = new Padding(4);
            rtbOmAvsnitt.Name = "rtbOmAvsnitt";
            rtbOmAvsnitt.Size = new Size(372, 329);
            rtbOmAvsnitt.TabIndex = 12;
            rtbOmAvsnitt.Text = "";
            rtbOmAvsnitt.TextChanged += richTextBox1_TextChanged;
            // 
            // lblMinaKategorier
            // 
            lblMinaKategorier.AutoSize = true;
            lblMinaKategorier.Location = new Point(15, 559);
            lblMinaKategorier.Margin = new Padding(4, 0, 4, 0);
            lblMinaKategorier.Name = "lblMinaKategorier";
            lblMinaKategorier.Size = new Size(140, 25);
            lblMinaKategorier.TabIndex = 13;
            lblMinaKategorier.Text = "Mina kategorier:";
            // 
            // listBoxKategori
            // 
            listBoxKategori.FormattingEnabled = true;
            listBoxKategori.Location = new Point(15, 588);
            listBoxKategori.Margin = new Padding(4);
            listBoxKategori.Name = "listBoxKategori";
            listBoxKategori.Size = new Size(346, 379);
            listBoxKategori.TabIndex = 14;
            listBoxKategori.SelectedIndexChanged += listBoxKategori_SelectedIndexChanged;
            // 
            // btnSparaNyKategori
            // 
            btnSparaNyKategori.Location = new Point(676, 610);
            btnSparaNyKategori.Margin = new Padding(4);
            btnSparaNyKategori.Name = "btnSparaNyKategori";
            btnSparaNyKategori.Size = new Size(116, 35);
            btnSparaNyKategori.TabIndex = 15;
            btnSparaNyKategori.Text = "Spara";
            btnSparaNyKategori.UseVisualStyleBackColor = true;
            btnSparaNyKategori.Click += btnSparaNyKategori_Click;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Location = new Point(370, 664);
            btnLaggTillKategori.Margin = new Padding(4);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(184, 40);
            btnLaggTillKategori.TabIndex = 16;
            btnLaggTillKategori.Text = "Lägg till i kategori";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // lblAllaPoddfloden
            // 
            lblAllaPoddfloden.AutoSize = true;
            lblAllaPoddfloden.Location = new Point(825, 559);
            lblAllaPoddfloden.Margin = new Padding(4, 0, 4, 0);
            lblAllaPoddfloden.Name = "lblAllaPoddfloden";
            lblAllaPoddfloden.Size = new Size(234, 25);
            lblAllaPoddfloden.TabIndex = 17;
            lblAllaPoddfloden.Text = "Alla poddflöden i kategorin:";
            // 
            // listBoxAllaPoddfloden
            // 
            listBoxAllaPoddfloden.FormattingEnabled = true;
            listBoxAllaPoddfloden.Location = new Point(825, 588);
            listBoxAllaPoddfloden.Margin = new Padding(4);
            listBoxAllaPoddfloden.Name = "listBoxAllaPoddfloden";
            listBoxAllaPoddfloden.Size = new Size(403, 379);
            listBoxAllaPoddfloden.TabIndex = 18;
            listBoxAllaPoddfloden.SelectedIndexChanged += listBoxAllaPoddfloden_SelectedIndexChanged;
            // 
            // btnTaBortPoddflode
            // 
            btnTaBortPoddflode.Location = new Point(1248, 724);
            btnTaBortPoddflode.Margin = new Padding(4);
            btnTaBortPoddflode.Name = "btnTaBortPoddflode";
            btnTaBortPoddflode.Size = new Size(185, 36);
            btnTaBortPoddflode.TabIndex = 19;
            btnTaBortPoddflode.Text = "Ta bort poddflöde";
            btnTaBortPoddflode.UseVisualStyleBackColor = true;
            btnTaBortPoddflode.Click += btnTaBortPoddflode_Click;
            // 
            // btnSparaNyttNamn
            // 
            btnSparaNyttNamn.Location = new Point(1502, 609);
            btnSparaNyttNamn.Margin = new Padding(4);
            btnSparaNyttNamn.Name = "btnSparaNyttNamn";
            btnSparaNyttNamn.Size = new Size(115, 36);
            btnSparaNyttNamn.TabIndex = 20;
            btnSparaNyttNamn.Text = "Spara";
            btnSparaNyttNamn.UseVisualStyleBackColor = true;
            btnSparaNyttNamn.Click += btnSparaNyttNamn_Click;
            // 
            // btnLaggTillNyKategori
            // 
            btnLaggTillNyKategori.Location = new Point(488, 996);
            btnLaggTillNyKategori.Margin = new Padding(4);
            btnLaggTillNyKategori.Name = "btnLaggTillNyKategori";
            btnLaggTillNyKategori.Size = new Size(118, 36);
            btnLaggTillNyKategori.TabIndex = 21;
            btnLaggTillNyKategori.Text = "Lägg till";
            btnLaggTillNyKategori.UseVisualStyleBackColor = true;
            btnLaggTillNyKategori.Click += btnLaggTillNyKategori_Click;
            // 
            // lblSkapaNyKategori
            // 
            lblSkapaNyKategori.AutoSize = true;
            lblSkapaNyKategori.Location = new Point(24, 1001);
            lblSkapaNyKategori.Margin = new Padding(4, 0, 4, 0);
            lblSkapaNyKategori.Name = "lblSkapaNyKategori";
            lblSkapaNyKategori.Size = new Size(158, 25);
            lblSkapaNyKategori.TabIndex = 22;
            lblSkapaNyKategori.Text = "Skapa ny kategori:";
            // 
            // textBoxAngeNyKategori
            // 
            textBoxAngeNyKategori.Location = new Point(194, 998);
            textBoxAngeNyKategori.Margin = new Padding(4);
            textBoxAngeNyKategori.Name = "textBoxAngeNyKategori";
            textBoxAngeNyKategori.Size = new Size(270, 31);
            textBoxAngeNyKategori.TabIndex = 23;
            // 
            // richTextBoxLankTillPoddflode
            // 
            richTextBoxLankTillPoddflode.Location = new Point(1646, 588);
            richTextBoxLankTillPoddflode.Margin = new Padding(4);
            richTextBoxLankTillPoddflode.Name = "richTextBoxLankTillPoddflode";
            richTextBoxLankTillPoddflode.Size = new Size(288, 379);
            richTextBoxLankTillPoddflode.TabIndex = 24;
            richTextBoxLankTillPoddflode.Text = "";
            richTextBoxLankTillPoddflode.TextChanged += richTextBoxLankTillPoddflode_TextChanged;
            // 
            // lblLankTillPoddflode
            // 
            lblLankTillPoddflode.AutoSize = true;
            lblLankTillPoddflode.Location = new Point(1646, 559);
            lblLankTillPoddflode.Margin = new Padding(4, 0, 4, 0);
            lblLankTillPoddflode.Name = "lblLankTillPoddflode";
            lblLankTillPoddflode.Size = new Size(165, 25);
            lblLankTillPoddflode.TabIndex = 25;
            lblLankTillPoddflode.Text = "Länk till poddflöde:";
            // 
            // textBoxAngeNyttNamnPodd
            // 
            textBoxAngeNyttNamnPodd.Location = new Point(1248, 611);
            textBoxAngeNyttNamnPodd.Margin = new Padding(4);
            textBoxAngeNyttNamnPodd.Name = "textBoxAngeNyttNamnPodd";
            textBoxAngeNyttNamnPodd.Size = new Size(246, 31);
            textBoxAngeNyttNamnPodd.TabIndex = 26;
            // 
            // textBoxAndraNamnKategori
            // 
            textBoxAndraNamnKategori.Location = new Point(370, 611);
            textBoxAndraNamnKategori.Margin = new Padding(4);
            textBoxAndraNamnKategori.Name = "textBoxAndraNamnKategori";
            textBoxAndraNamnKategori.Size = new Size(298, 31);
            textBoxAndraNamnKategori.TabIndex = 27;
            // 
            // lblAngeNyttNamn
            // 
            lblAngeNyttNamn.AutoSize = true;
            lblAngeNyttNamn.Location = new Point(1248, 582);
            lblAngeNyttNamn.Margin = new Padding(4, 0, 4, 0);
            lblAngeNyttNamn.Name = "lblAngeNyttNamn";
            lblAngeNyttNamn.Size = new Size(259, 25);
            lblAngeNyttNamn.TabIndex = 28;
            lblAngeNyttNamn.Text = "Ange nytt namn på poddflöde:";
            // 
            // lblNyttNamnKategori
            // 
            lblNyttNamnKategori.AutoSize = true;
            lblNyttNamnKategori.Location = new Point(370, 582);
            lblNyttNamnKategori.Margin = new Padding(4, 0, 4, 0);
            lblNyttNamnKategori.Name = "lblNyttNamnKategori";
            lblNyttNamnKategori.Size = new Size(239, 25);
            lblNyttNamnKategori.TabIndex = 29;
            lblNyttNamnKategori.Text = "Ange nytt namn på kategori:";
            // 
            // btnSparaBytKategori
            // 
            btnSparaBytKategori.Location = new Point(1505, 670);
            btnSparaBytKategori.Name = "btnSparaBytKategori";
            btnSparaBytKategori.Size = new Size(112, 34);
            btnSparaBytKategori.TabIndex = 30;
            btnSparaBytKategori.Text = "Spara";
            btnSparaBytKategori.UseVisualStyleBackColor = true;
            btnSparaBytKategori.Click += btnSparaBytKategori_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1048);
            Controls.Add(btnSparaBytKategori);
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
            Margin = new Padding(4);
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
        private Button btnSparaBytKategori;
    }
}
