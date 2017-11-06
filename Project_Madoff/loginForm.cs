using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace Project_Madoff
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void nameTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void csvLocTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileBrowseBtn_Click(object sender, EventArgs e)
        {

            String name = this.nameTBox.Text;
            String csvLocation;

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    csvLocTBox.Text = ofd.FileName;
                    csvLocation = ofd.FileName;
                }
            }

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            var userName = nameTBox.Text;
            int checker = 0;
            //float cash = 0;
            //float portVal = 0;

            String name = this.nameTBox.Text;
            

            String csvLocation = this.csvLocTBox.Text;

            
            String profileName;
        
            
            using (var reader = new StreamReader(csvLocation))
            using (var csvReader = new CsvReader(reader))
            {

                csvReader.Read();

                profileName  = csvReader.GetField(0);

                /*
                cash         = float.Parse(csvReader.GetField(1));
                portVal      = float.Parse(csvReader.GetField(2));
                */

                if (profileName.Equals(name))
                {
                    checker = 1;
                }

            }
            

            if (checker == 1)
            {

              //applicationForm open = new applicationForm(csvLocation, name, cash, portVal);
                applicationForm open = new applicationForm(csvLocation);
                this.Hide();
                open.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Incorrect user name");
                return;
            }


            /*
                do
                {
                    var reader = new StreamReader(csvLocation);
                    var csvReader = new CsvReader(reader);


                    csvReader.Read();

                    String profileName = csvReader.GetField(0);
                    cash = float.Parse(csvReader.GetField(1));
                    portVal = float.Parse(csvReader.GetField(2));

                    if (profileName.Equals(name))
                    {

                        checker = 1;

                    }
                    else
                    {



                    }
                } while (checker != 1);
              */
        }

        private void createProBtn_Click(object sender, EventArgs e)
        {

            createProfileForm open = new createProfileForm();
            open.Show();

        }
    }
}

