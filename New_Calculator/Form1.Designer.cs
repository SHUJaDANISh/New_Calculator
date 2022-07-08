
namespace New_Calculator
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
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.Clearelmnt = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lCurrentOp = new System.Windows.Forms.Label();
            this.Modulus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.InfoText;
            this.n8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.n8.FlatAppearance.BorderSize = 0;
            this.n8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.n8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n8.ForeColor = System.Drawing.Color.GhostWhite;
            this.n8.Location = new System.Drawing.Point(62, 123);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(45, 51);
            this.n8.TabIndex = 0;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n_click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.InfoText;
            this.n7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.n7.FlatAppearance.BorderSize = 0;
            this.n7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.n7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.n7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n7.ForeColor = System.Drawing.Color.GhostWhite;
            this.n7.Location = new System.Drawing.Point(11, 123);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(46, 51);
            this.n7.TabIndex = 1;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n_click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.ControlText;
            this.n9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.n9.FlatAppearance.BorderSize = 0;
            this.n9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.n9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n9.Location = new System.Drawing.Point(114, 123);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(45, 51);
            this.n9.TabIndex = 2;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n_click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.Black;
            this.div.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.div.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.div.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.div.Location = new System.Drawing.Point(168, 123);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(45, 51);
            this.div.TabIndex = 3;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.op_click);
            // 
            // Clearelmnt
            // 
            this.Clearelmnt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clearelmnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clearelmnt.Location = new System.Drawing.Point(218, 123);
            this.Clearelmnt.Name = "Clearelmnt";
            this.Clearelmnt.Size = new System.Drawing.Size(45, 51);
            this.Clearelmnt.TabIndex = 4;
            this.Clearelmnt.Text = "CE";
            this.Clearelmnt.UseVisualStyleBackColor = true;
            this.Clearelmnt.Click += new System.EventHandler(this.Clearelmnt_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.Color.Black;
            this.sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sub.Location = new System.Drawing.Point(165, 243);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(45, 45);
            this.sub.TabIndex = 8;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.op_click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.ControlText;
            this.n3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.n3.FlatAppearance.BorderSize = 0;
            this.n3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.n3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n3.Location = new System.Drawing.Point(114, 243);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(45, 45);
            this.n3.TabIndex = 7;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n_click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.InfoText;
            this.n2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.n2.FlatAppearance.BorderSize = 0;
            this.n2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.n2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n2.ForeColor = System.Drawing.Color.GhostWhite;
            this.n2.Location = new System.Drawing.Point(63, 243);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(45, 45);
            this.n2.TabIndex = 6;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n_click);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.InfoText;
            this.n1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.n1.FlatAppearance.BorderSize = 0;
            this.n1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.n1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n1.ForeColor = System.Drawing.Color.GhostWhite;
            this.n1.Location = new System.Drawing.Point(12, 243);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(45, 45);
            this.n1.TabIndex = 5;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n_click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.equal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equal.Location = new System.Drawing.Point(216, 243);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(45, 96);
            this.equal.TabIndex = 14;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Black;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.Location = new System.Drawing.Point(165, 294);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(45, 45);
            this.add.TabIndex = 13;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.op_click);
            // 
            // dot
            // 
            this.dot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.dot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.dot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dot.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dot.Location = new System.Drawing.Point(114, 294);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(45, 45);
            this.dot.TabIndex = 12;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.n_click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.InfoText;
            this.n0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.n0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.n0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n0.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n0.ForeColor = System.Drawing.Color.GhostWhite;
            this.n0.Location = new System.Drawing.Point(50, 297);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(67, 45);
            this.n0.TabIndex = 10;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n_click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.ForeColor = System.Drawing.Color.Black;
            this.clear.Location = new System.Drawing.Point(219, 180);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(45, 57);
            this.clear.TabIndex = 19;
            this.clear.Text = "c";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.Color.Black;
            this.mul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mul.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mul.Location = new System.Drawing.Point(166, 180);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(45, 57);
            this.mul.TabIndex = 18;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.op_click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.ControlText;
            this.n6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.n6.FlatAppearance.BorderSize = 0;
            this.n6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.n6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n6.Location = new System.Drawing.Point(114, 180);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(45, 57);
            this.n6.TabIndex = 17;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n_click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.InfoText;
            this.n4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.n4.FlatAppearance.BorderSize = 0;
            this.n4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.n4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n4.ForeColor = System.Drawing.Color.GhostWhite;
            this.n4.Location = new System.Drawing.Point(12, 180);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(45, 57);
            this.n4.TabIndex = 16;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n_click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.InfoText;
            this.n5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.n5.FlatAppearance.BorderSize = 0;
            this.n5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.n5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n5.ForeColor = System.Drawing.Color.GhostWhite;
            this.n5.Location = new System.Drawing.Point(63, 180);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(45, 57);
            this.n5.TabIndex = 15;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n_click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(11, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 62);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lCurrentOp
            // 
            this.lCurrentOp.AutoSize = true;
            this.lCurrentOp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lCurrentOp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lCurrentOp.Location = new System.Drawing.Point(13, 13);
            this.lCurrentOp.Name = "lCurrentOp";
            this.lCurrentOp.Size = new System.Drawing.Size(0, 28);
            this.lCurrentOp.TabIndex = 22;
            // 
            // Modulus
            // 
            this.Modulus.BackColor = System.Drawing.Color.Black;
            this.Modulus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modulus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Modulus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Modulus.Location = new System.Drawing.Point(13, 297);
            this.Modulus.Name = "Modulus";
            this.Modulus.Size = new System.Drawing.Size(45, 45);
            this.Modulus.TabIndex = 23;
            this.Modulus.Text = "%";
            this.Modulus.UseVisualStyleBackColor = false;
            this.Modulus.Click += new System.EventHandler(this.op_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(275, 365);
            this.Controls.Add(this.Modulus);
            this.Controls.Add(this.lCurrentOp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.Clearelmnt);
            this.Controls.Add(this.div);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button Clearelmnt;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCurrentOp;
        private System.Windows.Forms.Button Modulus;
    }
}

