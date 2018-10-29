namespace Mødeplanlægger_CS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.agendaTimeBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.addAgenda = new System.Windows.Forms.Button();
            this.removeAgenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agendaTimeBox1
            // 
            this.agendaTimeBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agendaTimeBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.agendaTimeBox1.FormattingEnabled = true;
            this.agendaTimeBox1.Items.AddRange(new object[] {
            "Vælg afsat tid",
            "5 min.",
            "10 min.",
            "15 min.",
            "20 min.",
            "25 min.",
            "30 min.",
            "35 min.",
            "40 min.",
            "45 min.",
            "50 min.",
            "55 min.",
            "60 min."});
            this.agendaTimeBox1.Location = new System.Drawing.Point(298, 56);
            this.agendaTimeBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.agendaTimeBox1.Name = "agendaTimeBox1";
            this.agendaTimeBox1.Size = new System.Drawing.Size(108, 24);
            this.agendaTimeBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(82, 56);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 23);
            this.textBox2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(10, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "2. Agenda";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nextButton.Location = new System.Drawing.Point(459, 159);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(96, 24);
            this.nextButton.TabIndex = 40;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.previousButton.Location = new System.Drawing.Point(357, 159);
            this.previousButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(96, 24);
            this.previousButton.TabIndex = 41;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Indtast de ønskede agendapunkter og allokér tid til disse:";
            // 
            // addAgenda
            // 
            this.addAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addAgenda.Location = new System.Drawing.Point(410, 56);
            this.addAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addAgenda.Name = "addAgenda";
            this.addAgenda.Size = new System.Drawing.Size(135, 25);
            this.addAgenda.TabIndex = 43;
            this.addAgenda.Text = "Tilføj agendapunkt";
            this.addAgenda.UseVisualStyleBackColor = true;
            this.addAgenda.Click += new System.EventHandler(this.addAgenda_Click);
            // 
            // removeAgenda
            // 
            this.removeAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removeAgenda.Location = new System.Drawing.Point(410, 85);
            this.removeAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeAgenda.Name = "removeAgenda";
            this.removeAgenda.Size = new System.Drawing.Size(135, 25);
            this.removeAgenda.TabIndex = 44;
            this.removeAgenda.Text = "Fjern agendapunkt";
            this.removeAgenda.UseVisualStyleBackColor = true;
            this.removeAgenda.Click += new System.EventHandler(this.removeAgenda_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(566, 194);
            this.Controls.Add(this.removeAgenda);
            this.Controls.Add(this.addAgenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.agendaTimeBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "B&R Mødeplanlægger";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox agendaTimeBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAgenda;
        private System.Windows.Forms.Button removeAgenda;
    }
}