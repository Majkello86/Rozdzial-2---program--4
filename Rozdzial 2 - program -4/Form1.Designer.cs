namespace Rozdzial_2___program__4
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
            this.ChangeText = new System.Windows.Forms.Button();
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.labelToChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeText
            // 
            this.ChangeText.Location = new System.Drawing.Point(38, 26);
            this.ChangeText.Name = "ChangeText";
            this.ChangeText.Size = new System.Drawing.Size(195, 23);
            this.ChangeText.TabIndex = 0;
            this.ChangeText.Text = "Klikniecie zmnienia etykiete";
            this.ChangeText.UseVisualStyleBackColor = true;
            this.ChangeText.Click += new System.EventHandler(this.ChangeText_Click);
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.Checked = true;
            this.enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckBox.Location = new System.Drawing.Point(335, 26);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(137, 17);
            this.enableCheckBox.TabIndex = 1;
            this.enableCheckBox.Text = "Wlacza zmiane etykiety";
            this.enableCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelToChange
            // 
            this.labelToChange.Location = new System.Drawing.Point(1, 59);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(480, 23);
            this.labelToChange.TabIndex = 2;
            this.labelToChange.Text = "Nacisnij przycisk, aby zmienic tresc.";
            this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 91);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.enableCheckBox);
            this.Controls.Add(this.ChangeText);
            this.Name = "Form1";
            this.Text = "Moja Aplikacja Windows";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeText;
        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.Label labelToChange;
    }
}

