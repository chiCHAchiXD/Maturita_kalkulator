namespace CalculatorWin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btProcess1DArrayGeneral = new System.Windows.Forms.Button();
            this.btProcess1DArray100 = new System.Windows.Forms.Button();
            this._1DSearch = new System.Windows.Forms.TextBox();
            this._1DRange = new System.Windows.Forms.TextBox();
            this._1DLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btProcess2DArray = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._2DColumnCount = new System.Windows.Forms.TextBox();
            this._2DRowCount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section choice";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 92);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "No test";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.rbSection_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "2D Array test";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.rbSection_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "1D Array test";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rbSection_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "1D Array test <0,99>";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rbSection_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btProcess1DArrayGeneral);
            this.groupBox2.Controls.Add(this.btProcess1DArray100);
            this.groupBox2.Controls.Add(this._1DSearch);
            this.groupBox2.Controls.Add(this._1DRange);
            this.groupBox2.Controls.Add(this._1DLength);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(201, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process all 1D Array methods";
            this.groupBox2.Visible = false;
            // 
            // btProcess1DArrayGeneral
            // 
            this.btProcess1DArrayGeneral.Location = new System.Drawing.Point(133, 115);
            this.btProcess1DArrayGeneral.Name = "btProcess1DArrayGeneral";
            this.btProcess1DArrayGeneral.Size = new System.Drawing.Size(145, 23);
            this.btProcess1DArrayGeneral.TabIndex = 7;
            this.btProcess1DArrayGeneral.Text = "Process 1D Array Generally";
            this.btProcess1DArrayGeneral.UseVisualStyleBackColor = true;
            this.btProcess1DArrayGeneral.Click += new System.EventHandler(this.btProcess1DArrayGeneral_Click);
            // 
            // btProcess1DArray100
            // 
            this.btProcess1DArray100.Location = new System.Drawing.Point(7, 115);
            this.btProcess1DArray100.Name = "btProcess1DArray100";
            this.btProcess1DArray100.Size = new System.Drawing.Size(120, 23);
            this.btProcess1DArray100.TabIndex = 6;
            this.btProcess1DArray100.Text = "Process 1D array 100";
            this.btProcess1DArray100.UseVisualStyleBackColor = true;
            this.btProcess1DArray100.Click += new System.EventHandler(this.btProcess1DArray100_Click);
            // 
            // _1DSearch
            // 
            this._1DSearch.Location = new System.Drawing.Point(75, 76);
            this._1DSearch.Name = "_1DSearch";
            this._1DSearch.Size = new System.Drawing.Size(100, 20);
            this._1DSearch.TabIndex = 5;
            // 
            // _1DRange
            // 
            this._1DRange.Location = new System.Drawing.Point(75, 50);
            this._1DRange.Name = "_1DRange";
            this._1DRange.Size = new System.Drawing.Size(100, 20);
            this._1DRange.TabIndex = 4;
            // 
            // _1DLength
            // 
            this._1DLength.Location = new System.Drawing.Point(75, 24);
            this._1DLength.Name = "_1DLength";
            this._1DLength.Size = new System.Drawing.Size(100, 20);
            this._1DLength.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Searched int";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Array range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Array length";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btProcess2DArray);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this._2DColumnCount);
            this.groupBox3.Controls.Add(this._2DRowCount);
            this.groupBox3.Location = new System.Drawing.Point(201, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Process all 2D Array methods";
            this.groupBox3.Visible = false;
            // 
            // btProcess2DArray
            // 
            this.btProcess2DArray.Location = new System.Drawing.Point(62, 71);
            this.btProcess2DArray.Name = "btProcess2DArray";
            this.btProcess2DArray.Size = new System.Drawing.Size(75, 23);
            this.btProcess2DArray.TabIndex = 4;
            this.btProcess2DArray.Text = "Process 2D arrayprocess1DArrayGeneral";
            this.btProcess2DArray.UseVisualStyleBackColor = true;
            this.btProcess2DArray.Click += new System.EventHandler(this.btProcess2DArray_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Column count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Row count";
            // 
            // _2DColumnCount
            // 
            this._2DColumnCount.Location = new System.Drawing.Point(88, 45);
            this._2DColumnCount.Name = "_2DColumnCount";
            this._2DColumnCount.Size = new System.Drawing.Size(100, 20);
            this._2DColumnCount.TabIndex = 1;
            // 
            // _2DRowCount
            // 
            this._2DRowCount.Location = new System.Drawing.Point(88, 19);
            this._2DRowCount.Name = "_2DRowCount";
            this._2DRowCount.Size = new System.Drawing.Size(100, 20);
            this._2DRowCount.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 452);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btProcess1DArrayGeneral;
        private System.Windows.Forms.Button btProcess1DArray100;
        private System.Windows.Forms.TextBox _1DSearch;
        private System.Windows.Forms.TextBox _1DRange;
        private System.Windows.Forms.TextBox _1DLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btProcess2DArray;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _2DColumnCount;
        private System.Windows.Forms.TextBox _2DRowCount;
    }
}

