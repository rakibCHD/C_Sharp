
namespace Arduino_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.nextButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.Line = new System.Windows.Forms.Label();
            this.Removed = new System.Windows.Forms.Label();
            this.Arrow = new System.Windows.Forms.Label();
            this.Click = new System.Windows.Forms.Label();
            this.Stay = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(227, 136);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(111, 35);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(7, 13);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(133, 24);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "messageLabel";
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Line.Location = new System.Drawing.Point(6, 38);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(322, 24);
            this.Line.TabIndex = 2;
            this.Line.Text = "----------------------------------------------------";
            // 
            // Removed
            // 
            this.Removed.AutoSize = true;
            this.Removed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removed.Location = new System.Drawing.Point(7, 69);
            this.Removed.Name = "Removed";
            this.Removed.Size = new System.Drawing.Size(202, 24);
            this.Removed.TabIndex = 3;
            this.Removed.Text = "Board is disconnected.";
            // 
            // Arrow
            // 
            this.Arrow.AutoSize = true;
            this.Arrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.26866F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrow.Location = new System.Drawing.Point(268, 94);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(34, 39);
            this.Arrow.TabIndex = 4;
            this.Arrow.Text = "⮮";
            // 
            // Click
            // 
            this.Click.AutoSize = true;
            this.Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Click.Location = new System.Drawing.Point(249, 70);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(81, 24);
            this.Click.TabIndex = 5;
            this.Click.Text = "Click for ";
            // 
            // Stay
            // 
            this.Stay.AutoSize = true;
            this.Stay.BackColor = System.Drawing.Color.Transparent;
            this.Stay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stay.ForeColor = System.Drawing.Color.Crimson;
            this.Stay.Location = new System.Drawing.Point(21, 107);
            this.Stay.Name = "Stay";
            this.Stay.Size = new System.Drawing.Size(169, 24);
            this.Stay.TabIndex = 6;
            this.Stay.Text = "Stay disconnected.";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(338, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 24);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "❌";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(370, 190);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Stay);
            this.Controls.Add(this.Click);
            this.Controls.Add(this.Arrow);
            this.Controls.Add(this.Removed);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.nextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action....";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Label Removed;
        private System.Windows.Forms.Label Arrow;
        private System.Windows.Forms.Label Click;
        private System.Windows.Forms.Label Stay;
        private System.Windows.Forms.Label Exit;
    }
}