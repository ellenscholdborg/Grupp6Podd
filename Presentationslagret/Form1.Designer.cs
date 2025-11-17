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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLaggTillRss = new Label();
            textBoxRssLank = new TextBox();
            btnHamtaAvsnitt = new Button();
            listBoxAvsnitt = new ListBox();
            listBoxGaTillAvsnitt = new ListBox();
            listBoxOmAvsnitt = new ListBox();
            lblAvsnitt = new Label();
            lblGaTillAvsnitt = new Label();
            lblOmAvsnitt = new Label();
            comboBoxLaggTillLista = new ComboBox();
            btnMinaListor = new Button();
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
            lblLaggTillRss.Click += label1_Click;
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
            btnHamtaAvsnitt.Location = new Point(12, 69);
            btnHamtaAvsnitt.Name = "btnHamtaAvsnitt";
            btnHamtaAvsnitt.Size = new Size(134, 29);
            btnHamtaAvsnitt.TabIndex = 2;
            btnHamtaAvsnitt.Text = "Hämta avsnitt";
            btnHamtaAvsnitt.UseVisualStyleBackColor = true;
            // 
            // listBoxAvsnitt
            // 
            listBoxAvsnitt.FormattingEnabled = true;
            listBoxAvsnitt.Location = new Point(12, 151);
            listBoxAvsnitt.Name = "listBoxAvsnitt";
            listBoxAvsnitt.Size = new Size(187, 224);
            listBoxAvsnitt.TabIndex = 3;
            // 
            // listBoxGaTillAvsnitt
            // 
            listBoxGaTillAvsnitt.FormattingEnabled = true;
            listBoxGaTillAvsnitt.Location = new Point(237, 151);
            listBoxGaTillAvsnitt.Name = "listBoxGaTillAvsnitt";
            listBoxGaTillAvsnitt.Size = new Size(197, 224);
            listBoxGaTillAvsnitt.TabIndex = 4;
            // 
            // listBoxOmAvsnitt
            // 
            listBoxOmAvsnitt.FormattingEnabled = true;
            listBoxOmAvsnitt.Location = new Point(490, 151);
            listBoxOmAvsnitt.Name = "listBoxOmAvsnitt";
            listBoxOmAvsnitt.Size = new Size(264, 224);
            listBoxOmAvsnitt.TabIndex = 5;
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
            lblGaTillAvsnitt.Location = new Point(237, 110);
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
            // comboBoxLaggTillLista
            // 
            comboBoxLaggTillLista.FormattingEnabled = true;
            comboBoxLaggTillLista.Location = new Point(490, 24);
            comboBoxLaggTillLista.Name = "comboBoxLaggTillLista";
            comboBoxLaggTillLista.Size = new Size(151, 28);
            comboBoxLaggTillLista.TabIndex = 9;
            comboBoxLaggTillLista.Text = "Lägg till i lista";
            // 
            // btnMinaListor
            // 
            btnMinaListor.Location = new Point(622, 409);
            btnMinaListor.Name = "btnMinaListor";
            btnMinaListor.Size = new Size(132, 29);
            btnMinaListor.TabIndex = 10;
            btnMinaListor.Text = "Mina listor";
            btnMinaListor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMinaListor);
            Controls.Add(comboBoxLaggTillLista);
            Controls.Add(lblOmAvsnitt);
            Controls.Add(lblGaTillAvsnitt);
            Controls.Add(lblAvsnitt);
            Controls.Add(listBoxOmAvsnitt);
            Controls.Add(listBoxGaTillAvsnitt);
            Controls.Add(listBoxAvsnitt);
            Controls.Add(btnHamtaAvsnitt);
            Controls.Add(textBoxRssLank);
            Controls.Add(lblLaggTillRss);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLaggTillRss;
        private TextBox textBoxRssLank;
        private Button btnHamtaAvsnitt;
        private ListBox listBoxAvsnitt;
        private ListBox listBoxGaTillAvsnitt;
        private ListBox listBoxOmAvsnitt;
        private Label lblAvsnitt;
        private Label lblGaTillAvsnitt;
        private Label lblOmAvsnitt;
        private ComboBox comboBoxLaggTillLista;
        private Button btnMinaListor;
    }
}
