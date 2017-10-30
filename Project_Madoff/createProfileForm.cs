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

            String name = this.createProTBox.Text;

            var data = new[]
            {
                new Database { ProfileName = name, Cash = 50000, PortVal = 0}
            };


            using (var textWriter = File.CreateText(@"F:\College\CSCI 491\Project Madoff\Project_Madoff_Solution\userdata\test.csv"))
            using (var csv = new CsvWriter(textWriter))

            {
                csv.Configuration.Delimiter = ",";
                csv.Configuration.HasHeaderRecord = false;
                csv.Configuration.AutoMap<Database>();


                //csvWriter.WriteHeader<Database>();
                csv.WriteRecords(data);
                textWriter.Flush();


                /*
                    Console.WriteLine(mem.ToArray);
                    var result = Encoding.GetString(mem.ToArray());
                    Console.WriteLine(result);
                */

            }

        }
    }

    public class Database
    {
        public string ProfileName { get; set; }
        public float Cash { get; set; }
        public float PortVal { get; set; }
    }

}
