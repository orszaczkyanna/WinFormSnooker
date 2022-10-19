
namespace WinFormSnooker
{
    partial class FormHozzaad
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.numUdNyeremeny = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOrszag = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHelyezes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUdNyeremeny)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(469, 118);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(111, 38);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Hozzáad";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // numUdNyeremeny
            // 
            this.numUdNyeremeny.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUdNyeremeny.Location = new System.Drawing.Point(469, 63);
            this.numUdNyeremeny.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numUdNyeremeny.Name = "numUdNyeremeny";
            this.numUdNyeremeny.Size = new System.Drawing.Size(111, 20);
            this.numUdNyeremeny.TabIndex = 16;
            this.numUdNyeremeny.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nyeremény";
            // 
            // cbOrszag
            // 
            this.cbOrszag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrszag.FormattingEnabled = true;
            this.cbOrszag.Items.AddRange(new object[] {
            "Anglia",
            "Ausztrália",
            "Belgium",
            "Ciprus",
            "Észak-Írország",
            "Hong Kong",
            "Irán",
            "Írország",
            "Kína",
            "Lengyelország",
            "Malajzia",
            "Norvégia",
            "Skócia",
            "Svájc",
            "Thaiföld",
            "Wales"});
            this.cbOrszag.Location = new System.Drawing.Point(318, 62);
            this.cbOrszag.Name = "cbOrszag";
            this.cbOrszag.Size = new System.Drawing.Size(121, 21);
            this.cbOrszag.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ország:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(183, 63);
            this.tbNev.MaxLength = 255;
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(105, 20);
            this.tbNev.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Név:";
            // 
            // tbHelyezes
            // 
            this.tbHelyezes.Location = new System.Drawing.Point(85, 63);
            this.tbHelyezes.MaxLength = 255;
            this.tbHelyezes.Name = "tbHelyezes";
            this.tbHelyezes.Size = new System.Drawing.Size(68, 20);
            this.tbHelyezes.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Helyezés:";
            // 
            // FormHozzaad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 185);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.numUdNyeremeny);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbOrszag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHelyezes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormHozzaad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új versenyző hozzáadása";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHozzaad_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numUdNyeremeny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.NumericUpDown numUdNyeremeny;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOrszag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHelyezes;
        private System.Windows.Forms.Label label1;
    }
}