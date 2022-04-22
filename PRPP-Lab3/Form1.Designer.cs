namespace PRPP_Lab3
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
            this.labelExp = new System.Windows.Forms.Label();
            this.textBoxExp = new System.Windows.Forms.TextBox();
            this.labelRes = new System.Windows.Forms.Label();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonBackSp = new System.Windows.Forms.Button();
            this.buttonRBrack = new System.Windows.Forms.Button();
            this.buttonLBrack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonMPLus = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonChangSign = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonRes = new System.Windows.Forms.Button();
            this.groupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExp.Location = new System.Drawing.Point(12, 28);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(90, 23);
            this.labelExp.TabIndex = 0;
            this.labelExp.Text = "Expression";
            // 
            // textBoxExp
            // 
            this.textBoxExp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxExp.Location = new System.Drawing.Point(108, 28);
            this.textBoxExp.Name = "textBoxExp";
            this.textBoxExp.Size = new System.Drawing.Size(328, 27);
            this.textBoxExp.TabIndex = 1;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRes.Location = new System.Drawing.Point(12, 67);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(56, 23);
            this.labelRes.TabIndex = 2;
            this.labelRes.Text = "Result";
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(108, 67);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.ReadOnly = true;
            this.textBoxRes.Size = new System.Drawing.Size(328, 27);
            this.textBoxRes.TabIndex = 3;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.buttonC);
            this.groupBoxEdit.Controls.Add(this.buttonBackSp);
            this.groupBoxEdit.Controls.Add(this.buttonRBrack);
            this.groupBoxEdit.Controls.Add(this.buttonLBrack);
            this.groupBoxEdit.Location = new System.Drawing.Point(12, 114);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(424, 86);
            this.groupBoxEdit.TabIndex = 4;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Editing";
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonC.ForeColor = System.Drawing.Color.Red;
            this.buttonC.Location = new System.Drawing.Point(330, 26);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(84, 54);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonBackSp
            // 
            this.buttonBackSp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackSp.ForeColor = System.Drawing.Color.Red;
            this.buttonBackSp.Location = new System.Drawing.Point(196, 26);
            this.buttonBackSp.Name = "buttonBackSp";
            this.buttonBackSp.Size = new System.Drawing.Size(118, 54);
            this.buttonBackSp.TabIndex = 2;
            this.buttonBackSp.Text = "Backspace";
            this.buttonBackSp.UseVisualStyleBackColor = true;
            // 
            // buttonRBrack
            // 
            this.buttonRBrack.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRBrack.Location = new System.Drawing.Point(74, 26);
            this.buttonRBrack.Name = "buttonRBrack";
            this.buttonRBrack.Size = new System.Drawing.Size(63, 54);
            this.buttonRBrack.TabIndex = 1;
            this.buttonRBrack.Text = ")";
            this.buttonRBrack.UseVisualStyleBackColor = true;
            this.buttonRBrack.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonLBrack
            // 
            this.buttonLBrack.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLBrack.Location = new System.Drawing.Point(6, 26);
            this.buttonLBrack.Name = "buttonLBrack";
            this.buttonLBrack.Size = new System.Drawing.Size(62, 54);
            this.buttonLBrack.TabIndex = 0;
            this.buttonLBrack.Text = "(";
            this.buttonLBrack.UseVisualStyleBackColor = true;
            this.buttonLBrack.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(18, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(86, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(155, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 53);
            this.button3.TabIndex = 7;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDiv.ForeColor = System.Drawing.Color.Red;
            this.buttonDiv.Location = new System.Drawing.Point(225, 220);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(64, 53);
            this.buttonDiv.TabIndex = 8;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonMR.Location = new System.Drawing.Point(362, 220);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(64, 53);
            this.buttonMR.TabIndex = 9;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(19, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 53);
            this.button4.TabIndex = 10;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(87, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 53);
            this.button5.TabIndex = 11;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(155, 279);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 53);
            this.button6.TabIndex = 12;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMult.ForeColor = System.Drawing.Color.Red;
            this.buttonMult.Location = new System.Drawing.Point(225, 279);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(64, 53);
            this.buttonMult.TabIndex = 13;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMPLus
            // 
            this.buttonMPLus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMPLus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonMPLus.Location = new System.Drawing.Point(362, 279);
            this.buttonMPLus.Name = "buttonMPLus";
            this.buttonMPLus.Size = new System.Drawing.Size(65, 53);
            this.buttonMPLus.TabIndex = 14;
            this.buttonMPLus.Text = "M+";
            this.buttonMPLus.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(19, 338);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 50);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(86, 338);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 50);
            this.button8.TabIndex = 16;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(155, 338);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 50);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinus.ForeColor = System.Drawing.Color.Red;
            this.buttonMinus.Location = new System.Drawing.Point(225, 338);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(64, 50);
            this.buttonMinus.TabIndex = 18;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonMC.Location = new System.Drawing.Point(362, 338);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(64, 50);
            this.buttonMC.TabIndex = 19;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            // 
            // buttonChangSign
            // 
            this.buttonChangSign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChangSign.Location = new System.Drawing.Point(19, 394);
            this.buttonChangSign.Name = "buttonChangSign";
            this.buttonChangSign.Size = new System.Drawing.Size(61, 54);
            this.buttonChangSign.TabIndex = 20;
            this.buttonChangSign.Text = "+/-";
            this.buttonChangSign.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button0.Location = new System.Drawing.Point(87, 394);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(63, 54);
            this.button0.TabIndex = 21;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMod.ForeColor = System.Drawing.Color.Red;
            this.buttonMod.Location = new System.Drawing.Point(155, 394);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(64, 54);
            this.buttonMod.TabIndex = 22;
            this.buttonMod.Text = "mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlus.ForeColor = System.Drawing.Color.Red;
            this.buttonPlus.Location = new System.Drawing.Point(225, 394);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(64, 54);
            this.buttonPlus.TabIndex = 23;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonRes
            // 
            this.buttonRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRes.ForeColor = System.Drawing.Color.Red;
            this.buttonRes.Location = new System.Drawing.Point(362, 394);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(64, 54);
            this.buttonRes.TabIndex = 24;
            this.buttonRes.Text = "=";
            this.buttonRes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 484);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonChangSign);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonMPLus);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.textBoxExp);
            this.Controls.Add(this.labelExp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Calc";
            this.groupBoxEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.TextBox textBoxExp;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonBackSp;
        private System.Windows.Forms.Button buttonRBrack;
        private System.Windows.Forms.Button buttonLBrack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonMPLus;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonChangSign;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonRes;
    }
}
