namespace CalculatorIVS
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
            this.btnd = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btneq = new System.Windows.Forms.Button();
            this.btndelce = new System.Windows.Forms.Button();
            this.btnneg = new System.Windows.Forms.Button();
            this.btndelc = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btnfact = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.btnpow = new System.Windows.Forms.Button();
            this.btnpow2 = new System.Windows.Forms.Button();
            this.btnnthroot = new System.Windows.Forms.Button();
            this.btnsqrt = new System.Windows.Forms.Button();
            this.btnrnd = new System.Windows.Forms.Button();
            this.btnln = new System.Windows.Forms.Button();
            this.btnlogx = new System.Windows.Forms.Button();
            this.btnp = new System.Windows.Forms.Button();
            this.btne = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 336);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(67, 60);
            this.btn1.TabIndex = 0;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.addNumber);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(80, 336);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(67, 60);
            this.btn2.TabIndex = 1;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.addNumber);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(153, 336);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 60);
            this.btn3.TabIndex = 2;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.addNumber);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 270);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(67, 60);
            this.btn4.TabIndex = 3;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.addNumber);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(80, 270);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(67, 60);
            this.btn5.TabIndex = 4;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.addNumber);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(153, 270);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 60);
            this.btn6.TabIndex = 5;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.addNumber);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 204);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(67, 60);
            this.btn7.TabIndex = 6;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.addNumber);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(80, 204);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(67, 60);
            this.btn8.TabIndex = 7;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.addNumber);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(153, 204);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 60);
            this.btn9.TabIndex = 8;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.addNumber);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(6, 403);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(67, 60);
            this.btn0.TabIndex = 9;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.addNumber);
            // 
            // btnd
            // 
            this.helpProvider.SetHelpString(this.btnd, "Decimal point.");
            this.btnd.Location = new System.Drawing.Point(80, 403);
            this.btnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnd.Name = "btnd";
            this.helpProvider.SetShowHelp(this.btnd, true);
            this.btnd.Size = new System.Drawing.Size(67, 60);
            this.btnd.TabIndex = 10;
            this.btnd.TabStop = false;
            this.btnd.Text = ",";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.addNumber);
            // 
            // btnadd
            // 
            this.helpProvider.SetHelpString(this.btnadd, "The addition sign.");
            this.btnadd.Location = new System.Drawing.Point(226, 336);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.helpProvider.SetShowHelp(this.btnadd, true);
            this.btnadd.Size = new System.Drawing.Size(67, 60);
            this.btnadd.TabIndex = 11;
            this.btnadd.TabStop = false;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.addOperation);
            // 
            // btnsub
            // 
            this.helpProvider.SetHelpString(this.btnsub, "The subtraction sign.");
            this.btnsub.Location = new System.Drawing.Point(226, 270);
            this.btnsub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsub.Name = "btnsub";
            this.helpProvider.SetShowHelp(this.btnsub, true);
            this.btnsub.Size = new System.Drawing.Size(67, 60);
            this.btnsub.TabIndex = 12;
            this.btnsub.TabStop = false;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.addOperation);
            // 
            // btndiv
            // 
            this.helpProvider.SetHelpString(this.btndiv, "The division sign.");
            this.btndiv.Location = new System.Drawing.Point(226, 138);
            this.btndiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndiv.Name = "btndiv";
            this.helpProvider.SetShowHelp(this.btndiv, true);
            this.btndiv.Size = new System.Drawing.Size(67, 60);
            this.btndiv.TabIndex = 13;
            this.btndiv.TabStop = false;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.addOperation);
            // 
            // btneq
            // 
            this.helpProvider.SetHelpNavigator(this.btneq, System.Windows.Forms.HelpNavigator.Index);
            this.helpProvider.SetHelpString(this.btneq, "Calculates the result.");
            this.btneq.Location = new System.Drawing.Point(153, 403);
            this.btneq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneq.Name = "btneq";
            this.helpProvider.SetShowHelp(this.btneq, true);
            this.btneq.Size = new System.Drawing.Size(140, 60);
            this.btneq.TabIndex = 14;
            this.btneq.TabStop = false;
            this.btneq.Text = "=";
            this.btneq.UseVisualStyleBackColor = true;
            this.btneq.Click += new System.EventHandler(this.calculate);
            // 
            // btndelce
            // 
            this.helpProvider.SetHelpString(this.btndelce, "Deletes just the value on the display.");
            this.btndelce.Location = new System.Drawing.Point(6, 138);
            this.btndelce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelce.Name = "btndelce";
            this.helpProvider.SetShowHelp(this.btndelce, true);
            this.btndelce.Size = new System.Drawing.Size(67, 60);
            this.btndelce.TabIndex = 15;
            this.btndelce.TabStop = false;
            this.btndelce.Text = "CE";
            this.btndelce.UseVisualStyleBackColor = true;
            this.btndelce.Click += new System.EventHandler(this.delete);
            // 
            // btnneg
            // 
            this.helpProvider.SetHelpString(this.btnneg, "Changes the sign of the value.");
            this.btnneg.Location = new System.Drawing.Point(153, 138);
            this.btnneg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnneg.Name = "btnneg";
            this.helpProvider.SetShowHelp(this.btnneg, true);
            this.btnneg.Size = new System.Drawing.Size(67, 60);
            this.btnneg.TabIndex = 16;
            this.btnneg.TabStop = false;
            this.btnneg.Text = "+/-";
            this.btnneg.UseVisualStyleBackColor = true;
            this.btnneg.Click += new System.EventHandler(this.addOperationUpdate);
            // 
            // btndelc
            // 
            this.helpProvider.SetHelpString(this.btndelc, "Deletes all the calculations in the memory.");
            this.btndelc.Location = new System.Drawing.Point(80, 138);
            this.btndelc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelc.Name = "btndelc";
            this.helpProvider.SetShowHelp(this.btndelc, true);
            this.btndelc.Size = new System.Drawing.Size(67, 60);
            this.btndelc.TabIndex = 17;
            this.btndelc.TabStop = false;
            this.btndelc.Text = "C";
            this.btndelc.UseVisualStyleBackColor = true;
            this.btndelc.Click += new System.EventHandler(this.delete);
            // 
            // btnmul
            // 
            this.helpProvider.SetHelpString(this.btnmul, "The multiplication sign.");
            this.btnmul.Location = new System.Drawing.Point(226, 204);
            this.btnmul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmul.Name = "btnmul";
            this.helpProvider.SetShowHelp(this.btnmul, true);
            this.btnmul.Size = new System.Drawing.Size(67, 60);
            this.btnmul.TabIndex = 18;
            this.btnmul.TabStop = false;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.addOperation);
            // 
            // btnfact
            // 
            this.helpProvider.SetHelpString(this.btnfact, "Factorial of the number.");
            this.btnfact.Location = new System.Drawing.Point(6, 56);
            this.btnfact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfact.Name = "btnfact";
            this.helpProvider.SetShowHelp(this.btnfact, true);
            this.btnfact.Size = new System.Drawing.Size(52, 36);
            this.btnfact.TabIndex = 19;
            this.btnfact.TabStop = false;
            this.btnfact.Text = "x!";
            this.btnfact.UseVisualStyleBackColor = true;
            this.btnfact.Click += new System.EventHandler(this.addOperationUpdate);
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultBox.Location = new System.Drawing.Point(6, 11);
            this.resultBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultBox.Size = new System.Drawing.Size(287, 36);
            this.resultBox.TabIndex = 25;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // btnpow
            // 
            this.helpProvider.SetHelpString(this.btnpow, "Provides the n-th power of the number.");
            this.btnpow.Location = new System.Drawing.Point(65, 56);
            this.btnpow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpow.Name = "btnpow";
            this.helpProvider.SetShowHelp(this.btnpow, true);
            this.btnpow.Size = new System.Drawing.Size(52, 36);
            this.btnpow.TabIndex = 26;
            this.btnpow.TabStop = false;
            this.btnpow.Text = "xⁿ";
            this.btnpow.UseVisualStyleBackColor = true;
            this.btnpow.Click += new System.EventHandler(this.addOperation);
            // 
            // btnpow2
            // 
            this.helpProvider.SetHelpString(this.btnpow2, "Provides the power of 2 of the number.");
            this.btnpow2.Location = new System.Drawing.Point(125, 56);
            this.btnpow2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpow2.Name = "btnpow2";
            this.helpProvider.SetShowHelp(this.btnpow2, true);
            this.btnpow2.Size = new System.Drawing.Size(52, 36);
            this.btnpow2.TabIndex = 27;
            this.btnpow2.TabStop = false;
            this.btnpow2.Text = "x²";
            this.btnpow2.UseVisualStyleBackColor = true;
            this.btnpow2.Click += new System.EventHandler(this.addOperationUpdate);
            // 
            // btnnthroot
            // 
            this.helpProvider.SetHelpString(this.btnnthroot, "Enter the n value, click on this button and then enter the x value.");
            this.btnnthroot.Location = new System.Drawing.Point(182, 56);
            this.btnnthroot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnthroot.Name = "btnnthroot";
            this.helpProvider.SetShowHelp(this.btnnthroot, true);
            this.btnnthroot.Size = new System.Drawing.Size(52, 36);
            this.btnnthroot.TabIndex = 28;
            this.btnnthroot.TabStop = false;
            this.btnnthroot.Text = "ⁿ√x";
            this.btnnthroot.UseVisualStyleBackColor = true;
            this.btnnthroot.Click += new System.EventHandler(this.addOperation);
            // 
            // btnsqrt
            // 
            this.helpProvider.SetHelpString(this.btnsqrt, "Provides square root of the number.");
            this.btnsqrt.Location = new System.Drawing.Point(241, 56);
            this.btnsqrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsqrt.Name = "btnsqrt";
            this.helpProvider.SetShowHelp(this.btnsqrt, true);
            this.btnsqrt.Size = new System.Drawing.Size(52, 36);
            this.btnsqrt.TabIndex = 29;
            this.btnsqrt.TabStop = false;
            this.btnsqrt.Text = "²√x";
            this.btnsqrt.UseVisualStyleBackColor = true;
            this.btnsqrt.Click += new System.EventHandler(this.addOperationUpdate);
            // 
            // btnrnd
            // 
            this.helpProvider.SetHelpString(this.btnrnd, "Random number. Enter the minimum value, then click the rand button and than enter" +
        " the max value.");
            this.btnrnd.Location = new System.Drawing.Point(241, 97);
            this.btnrnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrnd.Name = "btnrnd";
            this.helpProvider.SetShowHelp(this.btnrnd, true);
            this.btnrnd.Size = new System.Drawing.Size(52, 36);
            this.btnrnd.TabIndex = 34;
            this.btnrnd.TabStop = false;
            this.btnrnd.Text = "rand";
            this.btnrnd.UseVisualStyleBackColor = true;
            this.btnrnd.Click += new System.EventHandler(this.addOperation);
            // 
            // btnln
            // 
            this.helpProvider.SetHelpString(this.btnln, "Enter the value and then click the ln button.");
            this.btnln.Location = new System.Drawing.Point(182, 97);
            this.btnln.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnln.Name = "btnln";
            this.helpProvider.SetShowHelp(this.btnln, true);
            this.btnln.Size = new System.Drawing.Size(52, 36);
            this.btnln.TabIndex = 33;
            this.btnln.TabStop = false;
            this.btnln.Text = "ln";
            this.btnln.UseVisualStyleBackColor = true;
            this.btnln.Click += new System.EventHandler(this.addOperationUpdate);
            // 
            // btnlogx
            // 
            this.helpProvider.SetHelpString(this.btnlogx, "Enter base, click log button and then enter the value.");
            this.btnlogx.Location = new System.Drawing.Point(125, 97);
            this.btnlogx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogx.Name = "btnlogx";
            this.helpProvider.SetShowHelp(this.btnlogx, true);
            this.btnlogx.Size = new System.Drawing.Size(52, 36);
            this.btnlogx.TabIndex = 32;
            this.btnlogx.TabStop = false;
            this.btnlogx.Text = "logₐx";
            this.btnlogx.UseVisualStyleBackColor = true;
            this.btnlogx.Click += new System.EventHandler(this.addOperation);
            // 
            // btnp
            // 
            this.helpProvider.SetHelpString(this.btnp, "Provides the pi number.");
            this.btnp.Location = new System.Drawing.Point(65, 97);
            this.btnp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnp.Name = "btnp";
            this.helpProvider.SetShowHelp(this.btnp, true);
            this.btnp.Size = new System.Drawing.Size(52, 36);
            this.btnp.TabIndex = 31;
            this.btnp.TabStop = false;
            this.btnp.Text = "π";
            this.btnp.UseVisualStyleBackColor = true;
            this.btnp.Click += new System.EventHandler(this.addNumber);
            // 
            // btne
            // 
            this.helpProvider.SetHelpString(this.btne, "Provies the e number.");
            this.btne.Location = new System.Drawing.Point(6, 97);
            this.btne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btne.Name = "btne";
            this.helpProvider.SetShowHelp(this.btne, true);
            this.btne.Size = new System.Drawing.Size(52, 36);
            this.btne.TabIndex = 30;
            this.btne.TabStop = false;
            this.btne.Text = "e";
            this.btne.UseVisualStyleBackColor = true;
            this.btne.Click += new System.EventHandler(this.addNumber);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(299, 467);
            this.Controls.Add(this.btnrnd);
            this.Controls.Add(this.btnln);
            this.Controls.Add(this.btnlogx);
            this.Controls.Add(this.btnp);
            this.Controls.Add(this.btne);
            this.Controls.Add(this.btnsqrt);
            this.Controls.Add(this.btnnthroot);
            this.Controls.Add(this.btnpow2);
            this.Controls.Add(this.btnpow);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.btnfact);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btndelc);
            this.Controls.Add(this.btnneg);
            this.Controls.Add(this.btndelce);
            this.Controls.Add(this.btneq);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnd);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "The BEST calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.addOperation);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnrnd;
        private System.Windows.Forms.Button btnln;
        private System.Windows.Forms.Button btnlogx;
        private System.Windows.Forms.Button btnp;
        private System.Windows.Forms.Button btne;
        private System.Windows.Forms.Button btnsqrt;
        private System.Windows.Forms.Button btnnthroot;
        private System.Windows.Forms.Button btnpow2;
        private System.Windows.Forms.Button btnpow;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button btnfact;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btndelc;
        private System.Windows.Forms.Button btnneg;
        private System.Windows.Forms.Button btndelce;
        private System.Windows.Forms.Button btneq;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnd;
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
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}

