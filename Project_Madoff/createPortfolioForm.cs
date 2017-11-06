using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace Project_Madoff
{
    public partial class createPortfolioForm : Form
    {
        
        public string userName { get; set; }
        private string directory { get; set; }
        //public string portName { get; set; }




        public createPortfolioForm(string name, string userFolder)
        {
            InitializeComponent();
            
            this.userName = name;

            directory = userFolder.TrimEnd('\\');
            directory.Remove(directory.LastIndexOf('\\') + 2);

        }

        private void createProtfolioForm_Load(object sender, EventArgs e)
        {

        }

        private void portNameTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createPortBtn_Click(object sender, EventArgs e)
        {

            string validCsvPath;

            string portName = this.portNameTBox.Text;


            validCsvPath = checkCsvName(directory, userName, portName);


            if (string.IsNullOrEmpty(validCsvPath) == true)
            {
                MessageBox.Show("This csv name already exists.\n" +
                                "Please chose another csv name or remove the csv\n" +
                                "filefrom the userdata folder");
                return;
            }
            else
            {

                var data = new[]
                {
                    new Database {ProfileName = userName, Cash = 50000, PortVal = 0}
                };


                using (var textWriter = File.CreateText(validCsvPath + ".csv"))
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

        public string checkCsvName(string directory, string userName, string portName)
        {

            string path = directory + portName;

            bool exists = File.Exists(path);

            if (!exists)
            {
                path = directory + portName;
            }
            else
            {
                path = null;
            }

            return path;

        }
    }
}
