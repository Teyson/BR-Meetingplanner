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
using HtmlAgilityPack;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Mødeplanlægger_CS
{

    public partial class Form1 : Form
    {
        Form2 f2;
        public List<string> names = new List<string>(200);
        public string currentDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        private string[] internalCallChoiceNames = new string[200];
        private string[] internalCoordinatorNames = new string[200];
        private string[] externalCallChoiceNames = new string[200];
        private string[] externalCoordinatorNames = new string[200];

        public Form1()
        {
            InitializeComponent();
        }

        private void addAgenda()
        {

        }

        private void showForm2()
        {
            if (f2 == null)
                f2 = new Form2(this);
            f2.Show();
            this.Hide();
        }

        public void getCoworkerNames()
        {
            if (updateCoworkerWarningBoolean())
            {
                try
                {
                    var web = new HtmlAgilityPack.HtmlWeb();
                    var doc = web.Load("http://10.45.10.149/brdkServices/EmployeeDB/");

                    var nodes = doc.DocumentNode
                        .SelectNodes("//*[@id=\"bootstrap-override\"]/div[1]/div/table/tbody//tr/td[1]").ToList();
                    var innerTexts = nodes.Select(node => node.InnerText).ToList();

                    for (int i = 0; i < innerTexts.Count(); i++)
                    {
                        if (i % 7 == 0)
                        {
                            names.Add(innerTexts[i]);
                        }
                    }
                    setCoworkerstoFile();
                }
                catch (System.Net.WebException)
                {
                    getCoworkersFromFile();
                }
                initDDL();
            }
            else
                return;
        }

        public void setCoworkerstoFile()
        {
            TextWriter tw = new StreamWriter(currentDirectory + @"\Coworker Names.txt");
            foreach (String s in names)
            {
                tw.WriteLine(s);
            }
            tw.Close();
        }

        public void getCoworkersFromFile()
        {
            try
            {
                names = File.ReadAllLines(currentDirectory + @"\Coworker Names.txt").ToList();
            }
            catch (FileNotFoundException)
            {
                var file = File.Open(currentDirectory + @"\Coworker Names.txt", FileMode.Create);
                file.Close();
                TextWriter tw = new StreamWriter(currentDirectory + @"\Coworker Names.txt");
                tw.WriteLine("Vælg Medarbejder");
                tw.Close();

                names = File.ReadAllLines(currentDirectory + @"\Coworker Names.txt").ToList();
            }
        }

        private DialogResult updateCoworkerWarning()
        {
            var result = MessageBox.Show(
                "Denne funktion kræver adgang til B&R Odenses trusted network.\n" +
                "Tjek venligst at du er på dette netværk!\n \n" +
                "Er du på B&R Odenses trusted network, så tryk OK.\n" +
                "Ellers tryk cancel.",
                "Network Warning!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
                );

            return result;
        }

        private Boolean updateCoworkerWarningBoolean()
        {
            var result = updateCoworkerWarning();
            if(result == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void initDDL()
        {
            names.CopyTo(internalCallChoiceNames);
            names.CopyTo(internalCoordinatorNames);
            names.CopyTo(externalCallChoiceNames);
            names.CopyTo(externalCoordinatorNames);
            internalCallChoice.DataSource = null;
            externalCallChoice.DataSource = null;
            internalCoordinator.DataSource = null;
            externalCoordinator.DataSource = null;
            internalCallChoice.DataSource = internalCallChoiceNames;
            externalCallChoice.DataSource = externalCallChoiceNames;
            internalCoordinator.DataSource = internalCoordinatorNames;
            externalCoordinator.DataSource = externalCoordinatorNames;

            externalCallChoice.SelectedIndex = 0;
            externalCoordinator.SelectedIndex = 0;
            internalCoordinator.SelectedIndex = 0;
            internalCallChoice.SelectedIndex = 0;

            externalCallChoice.Refresh();
            externalCoordinator.Refresh();
            internalCallChoice.Refresh();
            internalCoordinator.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialization of dropdown choice lists
            getCoworkersFromFile();
            initDDL();
        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            showForm2();
        }

        private void updateCoworkerDataButton_Click(object sender, EventArgs e)
        {
            getCoworkerNames();
        }
    }
}
