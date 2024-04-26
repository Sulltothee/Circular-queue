namespace Circular_Queue
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
            this.CountDisplay = new System.Windows.Forms.TextBox();
            this.TextBoxSupreme = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CountDisplay
            // 
            this.CountDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CountDisplay.Location = new System.Drawing.Point(22, 12);
            this.CountDisplay.Name = "CountDisplay";
            this.CountDisplay.ReadOnly = true;
            this.CountDisplay.Size = new System.Drawing.Size(100, 31);
            this.CountDisplay.TabIndex = 0;
            this.CountDisplay.Text = "0/10";
            // 
            // TextBoxSupreme
            // 
            this.TextBoxSupreme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSupreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.TextBoxSupreme.Location = new System.Drawing.Point(273, 184);
            this.TextBoxSupreme.Name = "TextBoxSupreme";
            this.TextBoxSupreme.Size = new System.Drawing.Size(222, 68);
            this.TextBoxSupreme.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Add.Location = new System.Drawing.Point(197, 286);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(165, 91);
            this.Add.TabIndex = 2;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Remove.Location = new System.Drawing.Point(409, 286);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(165, 91);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "REMOVE";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TextBoxSupreme);
            this.Controls.Add(this.CountDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CountDisplay;
        private System.Windows.Forms.TextBox TextBoxSupreme;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
    }
}

