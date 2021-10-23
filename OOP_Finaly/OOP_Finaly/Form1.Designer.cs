
namespace OOP_Finaly
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
            this.FormExit = new System.Windows.Forms.Button();
            this.FormChange = new System.Windows.Forms.Button();
            this.FormInput = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormExit
            // 
            this.FormExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormExit.Location = new System.Drawing.Point(410, 2);
            this.FormExit.Name = "FormExit";
            this.FormExit.Size = new System.Drawing.Size(200, 23);
            this.FormExit.TabIndex = 3;
            this.FormExit.Text = "Выход";
            this.FormExit.UseVisualStyleBackColor = false;
            this.FormExit.Click += new System.EventHandler(this.FormExit_Click_1);
            // 
            // FormChange
            // 
            this.FormChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormChange.Location = new System.Drawing.Point(205, 2);
            this.FormChange.Name = "FormChange";
            this.FormChange.Size = new System.Drawing.Size(200, 23);
            this.FormChange.TabIndex = 4;
            this.FormChange.Text = "Изменить";
            this.FormChange.UseVisualStyleBackColor = false;
            this.FormChange.Click += new System.EventHandler(this.FormChange_Click_1);
            // 
            // FormInput
            // 
            this.FormInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormInput.Location = new System.Drawing.Point(0, 1);
            this.FormInput.Name = "FormInput";
            this.FormInput.Size = new System.Drawing.Size(200, 24);
            this.FormInput.TabIndex = 5;
            this.FormInput.Text = "Ввод данных";
            this.FormInput.UseVisualStyleBackColor = false;
            this.FormInput.Click += new System.EventHandler(this.FormInput_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(255, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 432);
            this.panel1.TabIndex = 3;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.FormInput);
            this.panel2.Controls.Add(this.FormExit);
            this.panel2.Controls.Add(this.FormChange);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 29);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(610, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(610, 462);
            this.MinimumSize = new System.Drawing.Size(610, 462);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FormExit;
        public System.Windows.Forms.Button FormChange;
        private System.Windows.Forms.Button FormInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

