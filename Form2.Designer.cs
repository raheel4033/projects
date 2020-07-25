namespace Project_DS
{
    partial class Form2
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
            this.btnShowArray = new System.Windows.Forms.Button();
            this.btnShowSorted = new System.Windows.Forms.Button();
            this.lstArray = new System.Windows.Forms.ListBox();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnHeap = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnQuick = new System.Windows.Forms.Button();
            this.btnCounting = new System.Windows.Forms.Button();
            this.txtBubble = new System.Windows.Forms.TextBox();
            this.txtSelection = new System.Windows.Forms.TextBox();
            this.txtHeap = new System.Windows.Forms.TextBox();
            this.txtMerge = new System.Windows.Forms.TextBox();
            this.txtQuick = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowArray
            // 
            this.btnShowArray.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnShowArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowArray.Location = new System.Drawing.Point(717, 231);
            this.btnShowArray.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowArray.Name = "btnShowArray";
            this.btnShowArray.Size = new System.Drawing.Size(186, 82);
            this.btnShowArray.TabIndex = 0;
            this.btnShowArray.Text = "Show Array";
            this.btnShowArray.UseVisualStyleBackColor = false;
            this.btnShowArray.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowSorted
            // 
            this.btnShowSorted.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnShowSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSorted.Location = new System.Drawing.Point(717, 370);
            this.btnShowSorted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowSorted.Name = "btnShowSorted";
            this.btnShowSorted.Size = new System.Drawing.Size(186, 82);
            this.btnShowSorted.TabIndex = 1;
            this.btnShowSorted.Text = "Show Sorted Array";
            this.btnShowSorted.UseVisualStyleBackColor = false;
            this.btnShowSorted.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lstArray
            // 
            this.lstArray.FormattingEnabled = true;
            this.lstArray.ItemHeight = 20;
            this.lstArray.Location = new System.Drawing.Point(934, 56);
            this.lstArray.Name = "lstArray";
            this.lstArray.Size = new System.Drawing.Size(142, 524);
            this.lstArray.TabIndex = 2;
            this.lstArray.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnBubble
            // 
            this.btnBubble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBubble.Location = new System.Drawing.Point(73, 397);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(92, 55);
            this.btnBubble.TabIndex = 3;
            this.btnBubble.Text = "Bubble Sort";
            this.btnBubble.UseVisualStyleBackColor = false;
            this.btnBubble.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSelection.Location = new System.Drawing.Point(324, 397);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(92, 55);
            this.btnSelection.TabIndex = 4;
            this.btnSelection.Text = "Selection Sort";
            this.btnSelection.UseVisualStyleBackColor = false;
            this.btnSelection.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnHeap
            // 
            this.btnHeap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHeap.Location = new System.Drawing.Point(564, 397);
            this.btnHeap.Name = "btnHeap";
            this.btnHeap.Size = new System.Drawing.Size(92, 55);
            this.btnHeap.TabIndex = 5;
            this.btnHeap.Text = "Heap Sort";
            this.btnHeap.UseVisualStyleBackColor = false;
            this.btnHeap.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btnMerge
            // 
            this.btnMerge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMerge.Location = new System.Drawing.Point(73, 514);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(92, 55);
            this.btnMerge.TabIndex = 6;
            this.btnMerge.Text = "Merge Sort";
            this.btnMerge.UseVisualStyleBackColor = false;
            this.btnMerge.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btnQuick
            // 
            this.btnQuick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnQuick.Location = new System.Drawing.Point(324, 514);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(92, 55);
            this.btnQuick.TabIndex = 7;
            this.btnQuick.Text = "Quick Sort";
            this.btnQuick.UseVisualStyleBackColor = false;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // btnCounting
            // 
            this.btnCounting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCounting.Location = new System.Drawing.Point(564, 514);
            this.btnCounting.Name = "btnCounting";
            this.btnCounting.Size = new System.Drawing.Size(92, 55);
            this.btnCounting.TabIndex = 8;
            this.btnCounting.Text = "Counting Sort";
            this.btnCounting.UseVisualStyleBackColor = false;
            this.btnCounting.Click += new System.EventHandler(this.btnCounting_Click);
            // 
            // txtBubble
            // 
            this.txtBubble.Location = new System.Drawing.Point(33, 473);
            this.txtBubble.Name = "txtBubble";
            this.txtBubble.Size = new System.Drawing.Size(176, 26);
            this.txtBubble.TabIndex = 9;
            this.txtBubble.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSelection
            // 
            this.txtSelection.Location = new System.Drawing.Point(283, 473);
            this.txtSelection.Name = "txtSelection";
            this.txtSelection.Size = new System.Drawing.Size(168, 26);
            this.txtSelection.TabIndex = 10;
            this.txtSelection.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtHeap
            // 
            this.txtHeap.Location = new System.Drawing.Point(528, 473);
            this.txtHeap.Name = "txtHeap";
            this.txtHeap.Size = new System.Drawing.Size(158, 26);
            this.txtHeap.TabIndex = 11;
            this.txtHeap.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtMerge
            // 
            this.txtMerge.Location = new System.Drawing.Point(33, 597);
            this.txtMerge.Name = "txtMerge";
            this.txtMerge.Size = new System.Drawing.Size(176, 26);
            this.txtMerge.TabIndex = 12;
            // 
            // txtQuick
            // 
            this.txtQuick.Location = new System.Drawing.Point(283, 597);
            this.txtQuick.Name = "txtQuick";
            this.txtQuick.Size = new System.Drawing.Size(177, 26);
            this.txtQuick.TabIndex = 13;
            this.txtQuick.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(528, 597);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(168, 26);
            this.txtCount.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Array Size:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Min Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Max Value:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(263, 126);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 26);
            this.txtSize.TabIndex = 18;
            this.txtSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(263, 202);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 26);
            this.txtMin.TabIndex = 19;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(263, 276);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 26);
            this.txtMax.TabIndex = 20;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSubmit.Location = new System.Drawing.Point(472, 149);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(109, 60);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Generate Array";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(472, 245);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 38);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(330, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "*Error Min Value Should be less than Max Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(444, 37);
            this.label5.TabIndex = 24;
            this.label5.Text = "Analysis On the Basis of Time";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 668);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtQuick);
            this.Controls.Add(this.txtMerge);
            this.Controls.Add(this.txtHeap);
            this.Controls.Add(this.txtSelection);
            this.Controls.Add(this.txtBubble);
            this.Controls.Add(this.btnCounting);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnHeap);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.lstArray);
            this.Controls.Add(this.btnShowSorted);
            this.Controls.Add(this.btnShowArray);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowArray;
        private System.Windows.Forms.Button btnShowSorted;
        private System.Windows.Forms.ListBox lstArray;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnHeap;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Button btnCounting;
        private System.Windows.Forms.TextBox txtBubble;
        private System.Windows.Forms.TextBox txtSelection;
        private System.Windows.Forms.TextBox txtHeap;
        private System.Windows.Forms.TextBox txtMerge;
        private System.Windows.Forms.TextBox txtQuick;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}