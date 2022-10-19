
namespace WinFormSnooker
{
    partial class MainForm
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
            this.dgvVersenyzok = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUjVersenyzo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numUdNyeremeny = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOrszag = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHelyezes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVersenyzok)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUdNyeremeny)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVersenyzok
            // 
            this.dgvVersenyzok.AllowUserToAddRows = false;
            this.dgvVersenyzok.AllowUserToDeleteRows = false;
            this.dgvVersenyzok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVersenyzok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVersenyzok.Location = new System.Drawing.Point(0, 184);
            this.dgvVersenyzok.MultiSelect = false;
            this.dgvVersenyzok.Name = "dgvVersenyzok";
            this.dgvVersenyzok.ReadOnly = true;
            this.dgvVersenyzok.Size = new System.Drawing.Size(669, 434);
            this.dgvVersenyzok.TabIndex = 9;
            this.dgvVersenyzok.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVersenyzok_ColumnHeaderMouseClick);
            this.dgvVersenyzok.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVersenyzok_ColumnHeaderMouseDoubleClick);
            this.dgvVersenyzok.SelectionChanged += new System.EventHandler(this.dgvVersenyzok_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btnUjVersenyzo);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numUdNyeremeny);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbOrszag);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbHelyezes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott versenyző adatai";
            // 
            // btnUjVersenyzo
            // 
            this.btnUjVersenyzo.Location = new System.Drawing.Point(47, 125);
            this.btnUjVersenyzo.Name = "btnUjVersenyzo";
            this.btnUjVersenyzo.Size = new System.Drawing.Size(111, 38);
            this.btnUjVersenyzo.TabIndex = 6;
            this.btnUjVersenyzo.Text = "Új versenyző";
            this.btnUjVersenyzo.UseVisualStyleBackColor = true;
            this.btnUjVersenyzo.Click += new System.EventHandler(this.btnUjVersenyzo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(529, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Törlés";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(388, 125);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 38);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Módosítás";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(47, 74);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(68, 20);
            this.tbId.TabIndex = 1;
            this.tbId.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Id:";
            // 
            // numUdNyeremeny
            // 
            this.numUdNyeremeny.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUdNyeremeny.Location = new System.Drawing.Point(529, 74);
            this.numUdNyeremeny.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numUdNyeremeny.Name = "numUdNyeremeny";
            this.numUdNyeremeny.Size = new System.Drawing.Size(111, 20);
            this.numUdNyeremeny.TabIndex = 5;
            this.numUdNyeremeny.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
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
            this.cbOrszag.Location = new System.Drawing.Point(378, 73);
            this.cbOrszag.Name = "cbOrszag";
            this.cbOrszag.Size = new System.Drawing.Size(121, 21);
            this.cbOrszag.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ország:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(243, 74);
            this.tbNev.MaxLength = 255;
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(105, 20);
            this.tbNev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // tbHelyezes
            // 
            this.tbHelyezes.Location = new System.Drawing.Point(145, 74);
            this.tbHelyezes.MaxLength = 255;
            this.tbHelyezes.Name = "tbHelyezes";
            this.tbHelyezes.Size = new System.Drawing.Size(68, 20);
            this.tbHelyezes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Helyezés:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvVersenyzok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snooker";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVersenyzok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUdNyeremeny)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVersenyzok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown numUdNyeremeny;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHelyezes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOrszag;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUjVersenyzo;
        private System.Windows.Forms.Button btnDelete;
    }
}

