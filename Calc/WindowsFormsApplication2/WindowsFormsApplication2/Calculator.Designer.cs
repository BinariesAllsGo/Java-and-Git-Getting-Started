namespace WindowsFormsApplication2
{
    partial class formCalculator
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonEqual = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonSubtract = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Gainsboro;
            this.txtResult.Location = new System.Drawing.Point(65, 24);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(124, 35);
            this.txtResult.TabIndex = 0;
            // 
            // ButtonEight
            // 
            this.ButtonEight.Location = new System.Drawing.Point(57, 188);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(42, 30);
            this.ButtonEight.TabIndex = 11;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = true;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Location = new System.Drawing.Point(12, 186);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(39, 30);
            this.ButtonSeven.TabIndex = 12;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = true;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.Location = new System.Drawing.Point(105, 188);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(40, 30);
            this.ButtonNine.TabIndex = 13;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = true;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.Location = new System.Drawing.Point(12, 224);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(39, 30);
            this.ButtonZero.TabIndex = 14;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = true;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // ButtonEqual
            // 
            this.ButtonEqual.Location = new System.Drawing.Point(57, 224);
            this.ButtonEqual.Name = "ButtonEqual";
            this.ButtonEqual.Size = new System.Drawing.Size(88, 30);
            this.ButtonEqual.TabIndex = 15;
            this.ButtonEqual.Text = "=";
            this.ButtonEqual.UseVisualStyleBackColor = true;
            this.ButtonEqual.Click += new System.EventHandler(this.ButtonEqual_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Location = new System.Drawing.Point(151, 224);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(40, 30);
            this.ButtonDivide.TabIndex = 16;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Location = new System.Drawing.Point(152, 188);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(39, 30);
            this.ButtonMultiply.TabIndex = 17;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.Location = new System.Drawing.Point(12, 150);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(39, 30);
            this.ButtonFour.TabIndex = 18;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = true;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.Location = new System.Drawing.Point(57, 152);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(42, 30);
            this.ButtonFive.TabIndex = 19;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = true;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.Location = new System.Drawing.Point(105, 152);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(40, 30);
            this.ButtonSix.TabIndex = 20;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = true;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
            // 
            // ButtonSubtract
            // 
            this.ButtonSubtract.Location = new System.Drawing.Point(151, 152);
            this.ButtonSubtract.Name = "ButtonSubtract";
            this.ButtonSubtract.Size = new System.Drawing.Size(40, 30);
            this.ButtonSubtract.TabIndex = 21;
            this.ButtonSubtract.Text = "-";
            this.ButtonSubtract.UseVisualStyleBackColor = true;
            this.ButtonSubtract.Click += new System.EventHandler(this.ButtonSubtract_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.Location = new System.Drawing.Point(12, 114);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(39, 30);
            this.ButtonOne.TabIndex = 22;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = true;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.Location = new System.Drawing.Point(57, 116);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(42, 30);
            this.ButtonTwo.TabIndex = 23;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = true;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.Location = new System.Drawing.Point(106, 116);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(39, 30);
            this.ButtonThree.TabIndex = 24;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = true;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(152, 116);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(39, 30);
            this.ButtonAdd.TabIndex = 25;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonC
            // 
            this.ButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonC.ForeColor = System.Drawing.Color.Red;
            this.ButtonC.Location = new System.Drawing.Point(12, 78);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(39, 30);
            this.ButtonC.TabIndex = 26;
            this.ButtonC.Text = "C";
            this.ButtonC.UseVisualStyleBackColor = true;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 36);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(47, 13);
            this.lblResult.TabIndex = 27;
            this.lblResult.Text = "Result:";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(114, 271);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 34);
            this.btnFechar.TabIndex = 28;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // formCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(210, 317);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.ButtonC);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonThree);
            this.Controls.Add(this.ButtonTwo);
            this.Controls.Add(this.ButtonOne);
            this.Controls.Add(this.ButtonSubtract);
            this.Controls.Add(this.ButtonSix);
            this.Controls.Add(this.ButtonFive);
            this.Controls.Add(this.ButtonFour);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonEqual);
            this.Controls.Add(this.ButtonZero);
            this.Controls.Add(this.ButtonNine);
            this.Controls.Add(this.ButtonSeven);
            this.Controls.Add(this.ButtonEight);
            this.Controls.Add(this.txtResult);
            this.MaximizeBox = false;
            this.Name = "formCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonEqual;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonSubtract;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnFechar;
    }
}

