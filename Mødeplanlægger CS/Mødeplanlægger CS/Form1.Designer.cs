namespace Mødeplanlægger_CS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.internalCallChoice = new System.Windows.Forms.ComboBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.updateCoworkerDataButton = new System.Windows.Forms.Button();
            this.externalCallChoice = new System.Windows.Forms.ComboBox();
            this.internalCoordinator = new System.Windows.Forms.ComboBox();
            this.externalCoordinator = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mødetitel: ";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitle.Location = new System.Drawing.Point(117, 8);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(554, 30);
            this.txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "1. Ansvar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(169, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "1.1 Hvem indkalder til mødet internt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(156, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "1.2 Hvem indkalder til mødet eksternt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(126, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "1.3 Hvem koordinerer aktiviteterne internt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(113, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "1.4 Hvem koordinerer aktiviteterne eksternt:";
            // 
            // internalCallChoice
            // 
            this.internalCallChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.internalCallChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.internalCallChoice.FormattingEnabled = true;
            this.internalCallChoice.Location = new System.Drawing.Point(450, 82);
            this.internalCallChoice.Margin = new System.Windows.Forms.Padding(4);
            this.internalCallChoice.Name = "internalCallChoice";
            this.internalCallChoice.Size = new System.Drawing.Size(185, 28);
            this.internalCallChoice.TabIndex = 7;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(661, 281);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(128, 29);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click_1);
            // 
            // updateCoworkerDataButton
            // 
            this.updateCoworkerDataButton.Location = new System.Drawing.Point(441, 281);
            this.updateCoworkerDataButton.Name = "updateCoworkerDataButton";
            this.updateCoworkerDataButton.Size = new System.Drawing.Size(214, 29);
            this.updateCoworkerDataButton.TabIndex = 12;
            this.updateCoworkerDataButton.Text = "Opdater medarbejder data";
            this.updateCoworkerDataButton.UseVisualStyleBackColor = true;
            this.updateCoworkerDataButton.Click += new System.EventHandler(this.updateCoworkerDataButton_Click);
            // 
            // externalCallChoice
            // 
            this.externalCallChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.externalCallChoice.FormattingEnabled = true;
            this.externalCallChoice.Location = new System.Drawing.Point(450, 118);
            this.externalCallChoice.Name = "externalCallChoice";
            this.externalCallChoice.Size = new System.Drawing.Size(185, 28);
            this.externalCallChoice.TabIndex = 13;
            // 
            // internalCoordinator
            // 
            this.internalCoordinator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.internalCoordinator.FormattingEnabled = true;
            this.internalCoordinator.Location = new System.Drawing.Point(450, 154);
            this.internalCoordinator.Name = "internalCoordinator";
            this.internalCoordinator.Size = new System.Drawing.Size(185, 28);
            this.internalCoordinator.TabIndex = 14;
            // 
            // externalCoordinator
            // 
            this.externalCoordinator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.externalCoordinator.FormattingEnabled = true;
            this.externalCoordinator.Location = new System.Drawing.Point(450, 190);
            this.externalCoordinator.Name = "externalCoordinator";
            this.externalCoordinator.Size = new System.Drawing.Size(185, 28);
            this.externalCoordinator.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(801, 322);
            this.Controls.Add(this.externalCoordinator);
            this.Controls.Add(this.internalCoordinator);
            this.Controls.Add(this.externalCallChoice);
            this.Controls.Add(this.updateCoworkerDataButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.internalCallChoice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "B&R Mødeplanlægger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox internalCallChoice;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button updateCoworkerDataButton;
        private System.Windows.Forms.ComboBox externalCallChoice;
        private System.Windows.Forms.ComboBox internalCoordinator;
        private System.Windows.Forms.ComboBox externalCoordinator;
    }
}

