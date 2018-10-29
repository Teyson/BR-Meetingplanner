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
    public partial class Form4 : Form
    {
        Form3 f3;
        //Form5 f5;
        private List<ComboBox> DDLList = new List<ComboBox>();
        int coworkerIndex = 0;
        List<string> names = new List<string>();
        public string currentDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        int yValue = 34;

        public Form4(Form3 _f3)
        {
            this.f3 = _f3;
            InitializeComponent();
        }

        private void addCoworkerBox()
        {
            DDLList.Add(new ComboBox());
            comboBoxInit(coworkerIndex);
            coworkerIndex++;
        }

        private void comboBoxInit(int i)
        {
            DDLList[i].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DDLList[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            DDLList[i].FormattingEnabled = true;
            yValue += 34;
            DDLList[i].Location = new System.Drawing.Point(308, yValue);
            DDLList[i].Name = "comboBox";
            DDLList[i].Size = new System.Drawing.Size(185, 28);
            DDLList[i].TabIndex = 2;
            DDLList[i].DataSource = names;
            DDLList[i].SelectedIndex = 0;
            Controls.Add(DDLList[i]);
        }

        private void getCoworkersFromFile()
        {
            names = File.ReadAllLines(currentDirectory + @"\Coworker Names.txt").ToList();
        }

        private void moveControlsDown()
        {
            //skal flyttes 34 i y-retningen
        }

        private void moveControlsUp()
        {
            //skal flyttes 34 i y-retningen
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            getCoworkersFromFile();
            DDLCoworker.DataSource = names;
            DDLCoworker.SelectedIndex = 0;
        }

        private void addCoworkerButton_Click_1(object sender, EventArgs e)
        {
            addCoworkerBox();
        }
    }
}
