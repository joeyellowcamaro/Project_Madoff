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
    public partial class createProfileForm : Form
    {
        public createProfileForm()
        {
            InitializeComponent();
        }

        private void createProfile_Load(object sender, EventArgs e)
        {

        }

        private void createProTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createProBtn_Click(object sender, EventArgs e)
        {

            string name = this.createProTBox.Text;
            string validatedPath;


            validatedPath = checkPath(name);


            if (string.IsNullOrEmpty(validatedPath) == true)
            {
                MessageBox.Show("This profile already exists.\n" +
                                "Please chose another name or remove the account \n" +
                                "folder from the userdata folder");
                return;
            }
            else
            {

                var data = new[]
                {
                    new Database {ProfileName = name, Cash = 50000, PortVal = 0}
                };

                using (var textWriter = File.CreateText(validatedPath + name + "Main.csv"))
                using (var csv = new CsvWriter(textWriter))
                {

                    csv.Configuration.Delimiter = ",";
                    csv.Configuration.HasHeaderRecord = false;
                    csv.Configuration.AutoMap<Database>();


                    //csvWriter.WriteHeader<Database>();
                    csv.WriteRecords(data);
                    textWriter.Flush();

                }
            }


            

        }

        public string checkPath(string name)
        {       

            string path = @"C:\Users\Joey\Desktop\Project_Madoff-master\Project_Madoff-master\userdata\" + name + "\\";

            bool exists = System.IO.Directory.Exists(path);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(path);
            }
            else
            {
                path = null;
            }

            return path;

        }

       
    }

    public class Database
    {
        public string ProfileName { get; set; }
        public float  Cash        { get; set; }
        public float  PortVal     { get; set; }
    }

}
