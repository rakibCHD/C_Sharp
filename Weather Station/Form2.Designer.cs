
namespace Weather_Station
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
            this.Stay = new System.Windows.Forms.Label();
            this.Click = new System.Windows.Forms.Label();
            this.Arrow = new System.Windows.Forms.Label();
            this.Removed = new System.Windows.Forms.Label();
            this.Line = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stay
            // 
            this.Stay.AutoSize = true;
            this.Stay.BackColor = System.Drawing.Color.Transparent;
            this.Stay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stay.ForeColor = System.Drawing.Color.Crimson;
            this.Stay.Location = new System.Drawing.Point(42, 116);
            this.Stay.Name = "Stay";
            this.Stay.Size = new System.Drawing.Size(169, 24);
            this.Stay.TabIndex = 13;
            this.Stay.Text = "Stay disconnected.";
            // 
            // Click
            // 
            this.Click.AutoSize = true;
            this.Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Click.Location = new System.Drawing.Point(270, 79);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(81, 24);
            this.Click.TabIndex = 12;
            this.Click.Text = "Click for ";
            // 
            // Arrow
            // 
            this.Arrow.AutoSize = true;
            this.Arrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.26866F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrow.Location = new System.Drawing.Point(289, 103);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(34, 39);
            this.Arrow.TabIndex = 11;
            this.Arrow.Text = "⮮";
            // 
            // Removed
            // 
            this.Removed.AutoSize = true;
            this.Removed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removed.Location = new System.Drawing.Point(28, 78);
            this.Removed.Name = "Removed";
            this.Removed.Size = new System.Drawing.Size(219, 24);
            this.Removed.TabIndex = 10;
            this.Removed.Text = "Arduino is disconnected.";
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Line.Location = new System.Drawing.Point(27, 47);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(322, 24);
            this.Line.TabIndex = 9;
            this.Line.Text = "----------------------------------------------------";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(28, 22);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(133, 24);
            this.messageLabel.TabIndex = 8;
            this.messageLabel.Text = "messageLabel";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(248, 145);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(111, 35);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 230);
            this.Controls.Add(this.Stay);
            this.Controls.Add(this.Click);
            this.Controls.Add(this.Arrow);
            this.Controls.Add(this.Removed);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.nextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
           // this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Stay;
        private System.Windows.Forms.Label Click;
        private System.Windows.Forms.Label Arrow;
        private System.Windows.Forms.Label Removed;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button nextButton;
    }
}