namespace Cinema
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
            this.dataGridViewSelected = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbxTtoalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Gunuz = new System.Windows.Forms.RadioButton();
            this.axsam = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSelected
            // 
            this.dataGridViewSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelected.Location = new System.Drawing.Point(238, 363);
            this.dataGridViewSelected.Name = "dataGridViewSelected";
            this.dataGridViewSelected.Size = new System.Drawing.Size(652, 260);
            this.dataGridViewSelected.TabIndex = 0;
            this.dataGridViewSelected.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSelected_RowHeaderMouseClick);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(46, 281);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(137, 62);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "ShowSeats";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(967, 281);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(117, 62);
            this.btnReserve.TabIndex = 3;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(274, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(652, 341);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(967, 367);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(117, 51);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Remove Ticked";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Visible = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(967, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 52);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(969, 521);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 52);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate Price";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbxTtoalPrice
            // 
            this.tbxTtoalPrice.Location = new System.Drawing.Point(989, 596);
            this.tbxTtoalPrice.Multiline = true;
            this.tbxTtoalPrice.Name = "tbxTtoalPrice";
            this.tbxTtoalPrice.Size = new System.Drawing.Size(95, 27);
            this.tbxTtoalPrice.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(906, 610);
            this.label1.MaximumSize = new System.Drawing.Size(100, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ümumi Qiymet:";
            // 
            // Gunuz
            // 
            this.Gunuz.AutoSize = true;
            this.Gunuz.Location = new System.Drawing.Point(967, 258);
            this.Gunuz.Name = "Gunuz";
            this.Gunuz.Size = new System.Drawing.Size(56, 17);
            this.Gunuz.TabIndex = 12;
            this.Gunuz.TabStop = true;
            this.Gunuz.Text = "Gunuz";
            this.Gunuz.UseVisualStyleBackColor = true;
            // 
            // axsam
            // 
            this.axsam.AutoSize = true;
            this.axsam.Location = new System.Drawing.Point(1022, 258);
            this.axsam.Name = "axsam";
            this.axsam.Size = new System.Drawing.Size(62, 17);
            this.axsam.TabIndex = 13;
            this.axsam.TabStop = true;
            this.axsam.Text = "Axsham";
            this.axsam.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 642);
            this.Controls.Add(this.axsam);
            this.Controls.Add(this.Gunuz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTtoalPrice);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridViewSelected);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSelected;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbxTtoalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Gunuz;
        private System.Windows.Forms.RadioButton axsam;
    }
}

