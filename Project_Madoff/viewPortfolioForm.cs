using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace Project_Madoff
{

    public partial class viewPortfolioForm : Form
    {

        public string csvLoc { get; set; }


        public viewPortfolioForm(string filename)
        {
            InitializeComponent();

            this.csvLoc = filename;

            //readcsv(csvLoc);

            /*
            var sr = new StreamReader(new FileStream(filename, FileMode.Open));
            var csv = new CsvReader(sr);
            csv.Configuration.HasHeaderRecord = false;
            csv.Configuration.HeaderValidated = null;
            csv.Configuration.MissingFieldFound = null;
            csv.Read();
           

            portfolioTemplateBindingSource.DataSource = csv.GetRecord<portfolioTemplate>();
            */

        }


        private void viewPortfolioForm_Load(object sender, EventArgs e)
        {

            //portfolioTemplateBindingSource.DataSource = new List<portfolioTemplate>();

            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(csvLoc))
            {
                
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

                portGrid.DataSource = dt;
            }
            //return dt;


        }

       /* 
        public DataTable readcsv(string file)
        {
            /*
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(file))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
            */


                /*
                DataTable dt = new DataTable();

                using (var reader = new StreamReader(file))
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.HasHeaderRecord = false;

                    while(csv.Read())
                    {
                        var row = dt.NewRow();
                        foreach (DataColumn column in dt.Columns)
                        {
                            row[column.ColumnName] = csv.GetField(column.DataType, column.ColumnName);
                        }
                        dt.Rows.Add(row);
                    }


                }

                return dt;
                */


                /*
                using (var stream = File.OpenRead(file))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        using (var csvReader = new CsvReader(reader))
                        {

                            while (csvReader.Read())
                            {



                            }
                            var row = dt.NewRow();
                            foreach(DataColumn column in dt.Columns)
                            {
                                row[column.ColumnName] = file.GetField()
                            }



                            /*
                            int i = 0;
                            while (csvReader.Read())
                            {
                                if (i == 0)
                                {
                                    foreach (var field in csvReader.FieldHeaders)
                                    {
                                        dt.Columns.Add(field);
                                    }
                                }

                                DataRow row = dt.NewRow();
                                foreach (var field in csvReader.FieldHeaders)
                                {
                                    row[field] = csvReader.GetField(field);
                                }
                                dt.Rows.Add(row);

                                i += 1;
                            }

                        }

                }return dt;*/



           

    }
}
