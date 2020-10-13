namespace WindowsFormsApp1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(31, 157);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.numberclick);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(98, 157);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.numberclick);
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(228, 157);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(50, 50);
            this.btnplus.TabIndex = 2;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(31, 293);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.numberclick);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(163, 222);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.numberclick);
            // 
            // btn9
            // 
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn9.Location = new System.Drawing.Point(163, 293);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.numberclick);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(98, 293);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.numberclick);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(163, 157);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.numberclick);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(31, 222);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.numberclick);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(98, 222);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.numberclick);
            // 
            // btnmin
            // 
            this.btnmin.Location = new System.Drawing.Point(284, 157);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(50, 50);
            this.btnmin.TabIndex = 2;
            this.btnmin.Text = "-";
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(228, 222);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(50, 50);
            this.btnmul.TabIndex = 2;
            this.btnmul.Text = "x";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(284, 222);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(50, 50);
            this.btndiv.TabIndex = 2;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(350, 157);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 50);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(228, 293);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 50);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.numberclick);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(350, 222);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(50, 50);
            this.btnAC.TabIndex = 2;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(31, 104);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(369, 27);
            this.textResult.TabIndex = 3;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(284, 293);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(50, 50);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bieu thuc tinh :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(143, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 20);
            this.label.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 367);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
    }
}

