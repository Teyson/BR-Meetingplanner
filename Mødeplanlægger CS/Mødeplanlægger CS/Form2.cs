using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mødeplanlægger_CS
{
    public partial class Form2 : Form
    {
        Form1 f1;
        Form3 f3;
        private List<ComboBox> timesList= new List<ComboBox>();
        private List<TextBox> agendaList = new List<TextBox>();
        int agendaIndex = 0;
        List<string> times = new List<string>();
        public string currentDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        int yValue = 56;
        int controlIndex = 0;

        private void initTimeList()
        {
            times.Add("Vælg afsat tid");
            times.Add("5 min.");
            times.Add("10 min.");
            times.Add("15 min.");
            times.Add("20 min.");
            times.Add("25 min.");
            times.Add("30 min.");
            times.Add("35 min.");
            times.Add("40 min.");
            times.Add("45 min.");
            times.Add("50 min.");
            times.Add("55 min.");
            times.Add("60 min.");
        }
        

        public Form2(Form1 _f1)
        {
            this.f1 = _f1;
            InitializeComponent();
        }

        private void showForm3()
        {
            if (f3 == null)
                f3 = new Form3(this);
            f3.Show();
            this.Hide();
        }

        private void agendaTextBoxInit(int i)
        {
            agendaList[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            agendaList[i].Location = new System.Drawing.Point(82, yValue);
            agendaList[i].Name = "textBox2";
            agendaList[i].Size = new System.Drawing.Size(212, 23);
            agendaList[i].TabIndex = 16;
            Controls.Add(agendaList[i]);
            controlIndex++;
        }

        private void agendaTimeComboBoxInit(int i)
        {
            timesList[i].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            timesList[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            timesList[i].FormattingEnabled = true;
            timesList[i].Location = new System.Drawing.Point(298, yValue);
            timesList[i].Name = "comboBox";
            timesList[i].Size = new System.Drawing.Size(108, 24);
            timesList[i].TabIndex = 2;
            timesList[i].DataSource = times;
            //timesList[i].SelectedIndex = 0;
            Controls.Add(timesList[i]);
            controlIndex++;
        }

        private void addAgendaPointAndTime()
        {
            timesList.Add(new ComboBox());
            agendaList.Add(new TextBox());
            yValue += 34;
            agendaTextBoxInit(agendaIndex);
            agendaTimeComboBoxInit(agendaIndex);
            agendaIndex++;
        }

        private void removeAgendaPointAndTime()
        {
            agendaIndex--;
            timesList.RemoveAt(agendaIndex);
            agendaList.RemoveAt(agendaIndex);
            Controls.RemoveAt(--controlIndex);
            Controls.RemoveAt(--controlIndex);
            yValue -= 34;
        }

        private void moveControlsDown()
        {
            nextButton.Location = new System.Drawing.Point(nextButton.Location.X, nextButton.Location.Y + 34);
            previousButton.Location = new System.Drawing.Point(previousButton.Location.X, previousButton.Location.Y + 34);
        }

        private void moveControlsUp()
        {
            nextButton.Location = new System.Drawing.Point(nextButton.Location.X, nextButton.Location.Y - 34);
            previousButton.Location = new System.Drawing.Point(previousButton.Location.X, previousButton.Location.Y - 34);
        }

        private void controlIndexInit()
        {
            foreach(Control control in Controls)
            {
                controlIndex++;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            showForm3();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            initTimeList();
            agendaTimeBox1.DataSource = times;
            agendaTimeBox1.SelectedIndex = 0;
            controlIndexInit();
        }

        private void addAgenda_Click(object sender, EventArgs e)
        {
            moveControlsDown();
            addAgendaPointAndTime();
        }

        private void removeAgenda_Click(object sender, EventArgs e)
        {
            if (agendaIndex > 0)
            {
                removeAgendaPointAndTime();
                moveControlsUp();
            }
        }
    }
}
