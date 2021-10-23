
namespace OOP_Finaly
{
    partial class Main
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
            this.MainExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelSyzeX = new System.Windows.Forms.Label();
            this.labelSizeY = new System.Windows.Forms.Label();
            this.MainInput = new System.Windows.Forms.Button();
            this.SizePlus = new System.Windows.Forms.RadioButton();
            this.SizeMinus = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // MainExit
            // 
            this.MainExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainExit.Location = new System.Drawing.Point(138, 171);
            this.MainExit.Name = "MainExit";
            this.MainExit.Size = new System.Drawing.Size(300, 45);
            this.MainExit.TabIndex = 0;
            this.MainExit.Text = "Выход";
            this.MainExit.UseVisualStyleBackColor = true;
            this.MainExit.Click += new System.EventHandler(this.MainExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // labelSyzeX
            // 
            this.labelSyzeX.AutoSize = true;
            this.labelSyzeX.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSyzeX.Location = new System.Drawing.Point(127, 44);
            this.labelSyzeX.Name = "labelSyzeX";
            this.labelSyzeX.Size = new System.Drawing.Size(82, 25);
            this.labelSyzeX.TabIndex = 3;
            this.labelSyzeX.Text = "Число X";
            // 
            // labelSizeY
            // 
            this.labelSizeY.AutoSize = true;
            this.labelSizeY.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSizeY.Location = new System.Drawing.Point(127, 76);
            this.labelSizeY.Name = "labelSizeY";
            this.labelSizeY.Size = new System.Drawing.Size(82, 25);
            this.labelSizeY.TabIndex = 4;
            this.labelSizeY.Text = "Число Y";
            // 
            // MainInput
            // 
            this.MainInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainInput.Location = new System.Drawing.Point(138, 117);
            this.MainInput.Name = "MainInput";
            this.MainInput.Size = new System.Drawing.Size(300, 45);
            this.MainInput.TabIndex = 5;
            this.MainInput.Text = "Ввод";
            this.MainInput.UseVisualStyleBackColor = true;
            this.MainInput.Click += new System.EventHandler(this.MainInput_Click);
            // 
            // SizePlus
            // 
            this.SizePlus.AutoSize = true;
            this.SizePlus.Location = new System.Drawing.Point(207, 12);
            this.SizePlus.Name = "SizePlus";
            this.SizePlus.Size = new System.Drawing.Size(85, 19);
            this.SizePlus.TabIndex = 8;
            this.SizePlus.TabStop = true;
            this.SizePlus.Text = "Прибавить";
            this.SizePlus.UseVisualStyleBackColor = true;
            this.SizePlus.CheckedChanged += new System.EventHandler(this.SizePlus_CheckedChanged);
            // 
            // SizeMinus
            // 
            this.SizeMinus.AutoSize = true;
            this.SizeMinus.Location = new System.Drawing.Point(298, 12);
            this.SizeMinus.Name = "SizeMinus";
            this.SizeMinus.Size = new System.Drawing.Size(63, 19);
            this.SizeMinus.TabIndex = 10;
            this.SizeMinus.TabStop = true;
            this.SizeMinus.Text = "Отнять";
            this.SizeMinus.UseVisualStyleBackColor = true;
            this.SizeMinus.CheckedChanged += new System.EventHandler(this.SizeMinus_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(577, 267);
            this.Controls.Add(this.SizeMinus);
            this.Controls.Add(this.SizePlus);
            this.Controls.Add(this.MainInput);
            this.Controls.Add(this.labelSizeY);
            this.Controls.Add(this.labelSyzeX);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MainExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(577, 267);
            this.MinimumSize = new System.Drawing.Size(577, 267);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelSyzeX;
        private System.Windows.Forms.Label labelSizeY;
        private System.Windows.Forms.Button MainInput;
        private System.Windows.Forms.RadioButton SizePlus;
        private System.Windows.Forms.RadioButton SizeMinus;
    }
}