﻿namespace CalculatorIVS
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
            if(disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btneq = new System.Windows.Forms.Button();
            this.btndelce = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btndelc = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.lbltest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(5, 342);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(67, 60);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.addNumber);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(79, 342);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(67, 60);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.addNumber);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(152, 342);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 60);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.addNumber);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(5, 276);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(67, 60);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.addNumber);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(79, 276);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(67, 60);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.addNumber);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(152, 276);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 60);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.addNumber);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(5, 210);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(67, 60);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.addNumber);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(79, 210);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(67, 60);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.addNumber);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(152, 210);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 60);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.addNumber);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(5, 409);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(67, 60);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.addNumber);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(79, 409);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 60);
            this.button11.TabIndex = 10;
            this.button11.Text = ",";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.addNumber);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(225, 342);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(67, 60);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.addOperation);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(225, 276);
            this.btnminus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(67, 60);
            this.btnminus.TabIndex = 12;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.addOperation);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(225, 144);
            this.btndiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(67, 60);
            this.btndiv.TabIndex = 13;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.addOperation);
            // 
            // btneq
            // 
            this.btneq.Location = new System.Drawing.Point(152, 409);
            this.btneq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneq.Name = "btneq";
            this.btneq.Size = new System.Drawing.Size(140, 60);
            this.btneq.TabIndex = 14;
            this.btneq.Text = "=";
            this.btneq.UseVisualStyleBackColor = true;
            this.btneq.Click += new System.EventHandler(this.calculate);
            // 
            // btndelce
            // 
            this.btndelce.Location = new System.Drawing.Point(5, 144);
            this.btndelce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelce.Name = "btndelce";
            this.btndelce.Size = new System.Drawing.Size(67, 60);
            this.btndelce.TabIndex = 15;
            this.btndelce.Text = "CE";
            this.btndelce.UseVisualStyleBackColor = true;
            this.btndelce.Click += new System.EventHandler(this.delete);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(152, 144);
            this.btndel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(67, 60);
            this.btndel.TabIndex = 16;
            this.btndel.Text = "delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.delete);
            // 
            // btndelc
            // 
            this.btndelc.Location = new System.Drawing.Point(79, 144);
            this.btndelc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelc.Name = "btndelc";
            this.btndelc.Size = new System.Drawing.Size(67, 60);
            this.btndelc.TabIndex = 17;
            this.btndelc.Text = "C";
            this.btndelc.UseVisualStyleBackColor = true;
            this.btndelc.Click += new System.EventHandler(this.delete);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(225, 210);
            this.btnmul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(67, 60);
            this.btnmul.TabIndex = 18;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.addOperation);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(5, 62);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(52, 36);
            this.button20.TabIndex = 19;
            this.button20.Text = "x!";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.addOperation);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(5, 5);
            this.resultBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resultBox.Size = new System.Drawing.Size(287, 50);
            this.resultBox.TabIndex = 25;
            this.resultBox.Text = "867";
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(64, 62);
            this.button26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(52, 36);
            this.button26.TabIndex = 26;
            this.button26.Text = "x?";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.addOperation);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(124, 62);
            this.button27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(52, 36);
            this.button27.TabIndex = 27;
            this.button27.Text = "x²";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.addOperation);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(181, 62);
            this.button28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(52, 36);
            this.button28.TabIndex = 28;
            this.button28.Text = "√x";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.addOperation);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(240, 62);
            this.button29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(52, 36);
            this.button29.TabIndex = 29;
            this.button29.Text = "??";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.addOperation);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(240, 103);
            this.button21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(52, 36);
            this.button21.TabIndex = 34;
            this.button21.Text = "??";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.addOperation);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(181, 103);
            this.button22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(52, 36);
            this.button22.TabIndex = 33;
            this.button22.Text = "??";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.addOperation);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(124, 103);
            this.button23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(52, 36);
            this.button23.TabIndex = 32;
            this.button23.Text = "??";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.addOperation);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(64, 103);
            this.button24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(52, 36);
            this.button24.TabIndex = 31;
            this.button24.Text = "π";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.addNumber);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(5, 103);
            this.button25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(52, 36);
            this.button25.TabIndex = 30;
            this.button25.Text = "e";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.addNumber);
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(99, 486);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(46, 17);
            this.lbltest.TabIndex = 35;
            this.lbltest.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(299, 515);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btndelc);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btndelce);
            this.Controls.Add(this.btneq);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "The BEST calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btndelc;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btndelce;
        private System.Windows.Forms.Button btneq;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbltest;
    }
}

