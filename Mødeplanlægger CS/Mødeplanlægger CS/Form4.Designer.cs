namespace Mødeplanlægger_CS
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DDLCoworker = new System.Windows.Forms.ComboBox();
            this.addCoworkerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "4. Forberedelse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(125, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "4.1 interne mødedeltagere:";
            // 
            // DDLCoworker
            // 
            this.DDLCoworker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DDLCoworker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DDLCoworker.FormattingEnabled = true;
            this.DDLCoworker.Location = new System.Drawing.Point(308, 34);
            this.DDLCoworker.Margin = new System.Windows.Forms.Padding(2);
            this.DDLCoworker.Name = "DDLCoworker";
            this.DDLCoworker.Size = new System.Drawing.Size(185, 24);
            this.DDLCoworker.TabIndex = 2;
            // 
            // addCoworkerButton
            // 
            this.addCoworkerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.addCoworkerButton.Location = new System.Drawing.Point(497, 34);
            this.addCoworkerButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCoworkerButton.Name = "addCoworkerButton";
            this.addCoworkerButton.Size = new System.Drawing.Size(130, 24);
            this.addCoworkerButton.TabIndex = 3;
            this.addCoworkerButton.Text = "Tilføj medarbejder";
            this.addCoworkerButton.UseVisualStyleBackColor = true;
            this.addCoworkerButton.Click += new System.EventHandler(this.addCoworkerButton_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(664, 366);
            this.Controls.Add(this.addCoworkerButton);
            this.Controls.Add(this.DDLCoworker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "B&R Mødeplanlægger";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DDLCoworker;
        private System.Windows.Forms.Button addCoworkerButton;
    }
}