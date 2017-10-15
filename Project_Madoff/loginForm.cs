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

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    csvLocTBox.Text = ofd.SafeFileName;
                    String csvLocation = ofd.FileName;

                    //var textReader = File.Open(@"F:\College\CSCI 491\C_YSQ_Solution\test.csv");
                    //var csv = new CsvReader(sr);
                    //using (var reader = new StreamReader(file.InputStream))
                    using (var sr = new StreamReader(csvLocation))
                    {
                        var csv = new CsvReader(sr);

                        String profileName = csv.GetField(0);

                        if (profileName.Equals(name))
                        {
                            MessageBox.Show("Error 404");
                        }
                        else
                        {
                            MessageBox.Show("Success");
                        }

                    }
                }
            }

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var userName = nameTBox.Text;
        }

        private void createProBtn_Click(object sender, EventArgs e)
        {

            createProfileForm create = new createProfileForm();
            create.Show();

        }
    }
}
