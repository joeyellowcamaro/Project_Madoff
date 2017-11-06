using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YSQ.core.Quotes;
using CsvHelper;

namespace Project_Madoff
{
    public partial class applicationForm : Form
    {

        public string csvLoc    { get; set; }
        public string name      { get; set; }
        public float  cash      { get; set; }
        public float  portVal   { get; set; }
        private string directory { get; set; }

        private static int num;


      //public applicationForm(String csvloc, String name, float cash, float portVal)
        public applicationForm(String csvLocation)
        {
            InitializeComponent();

            webBrowser.ScriptErrorsSuppressed = true;

            this.csvLoc = csvLocation;


            /*
            this.name    = name;
            this.cash    = cash;
            this.portVal = portVal;
           

            nameLabel.Text    = name;
            cashLabel.Text    = "$" + Convert.ToString(cash);
            portValLabel.Text = "$" + Convert.ToString(portVal);
            */

            
            float  csvcash = 0;
            float  csvportVal = 0;
            String csvprofileName;
            //String predirectory;


            directory = csvLoc.TrimEnd('\\');

            directory.Remove(directory.LastIndexOf('\\') + 1);

            
            using (var reader = new StreamReader(csvLoc))
            using (var csvReader = new CsvReader(reader))
            {

                csvReader.Read();

                csvprofileName = csvReader.GetField(0);
                csvcash         = float.Parse(csvReader.GetField(1));
                csvportVal      = float.Parse(csvReader.GetField(2));

                this.name    = csvprofileName;
                this.cash    = csvcash;
                this.portVal = csvportVal;

            }

            nameLabel.Text = name;
            cashLabel.Text = "$" + Convert.ToString(cash);
            portValLabel.Text = "$" + Convert.ToString(portVal);


        }

        private void applicationForm_Load(object sender, EventArgs e)
        {

        }

        private void tickerTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sharesTBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {

            
            var quote_service = new QuoteService();

            String ticker = this.tickerTBox.Text.Replace(" ", "");


           // if (ticker == null)
           // {
           //
           // }
           // else
           // {
           //     var quote = quote_service.Quote(ticker).Return(QuoteReturnParameter.Open);
            //}
            



            /*
            using (FileStream textwriter = File.Open(csvloc, FileMode.Append, FileAccess.Write))
            using (var csv = new CsvWriter(textwriter))
            {



            }
            */

            // using (var sr = new StreamReader(csvloc))
            //{

            if (sharesTBox.Text != "0")
            {


                using (var textreader = new StreamReader(csvLoc))
                using (var csRead = new CsvReader(textreader))
                {





                }


                using (var textWriter = new StreamWriter(csvLoc, append: true))
                using (var csvWrite = new CsvWriter(textWriter))
                {

                    var data = new[]
                    {
                        new Portfolio {Ticker = tickerTBox.Text, Shares = sharesTBox.Text, TotalMon = "FIX" }
                    };


                    csvWrite.Configuration.Delimiter = ",";
                    csvWrite.Configuration.HasHeaderRecord = false;
                    csvWrite.Configuration.AutoMap<Portfolio>();


                    csvWrite.WriteRecords(data);
                    textWriter.Flush();

                }
                
            }
            else
            {



            }

        }

        private void sellBtn_Click(object sender, EventArgs e)
        {

        }

        private void incBtn_Click(object sender, EventArgs e)
        {
            this.incBtn.BackgroundImage = Project_Madoff.Properties.Resources.upArrow;


            num++;
            sharesTBox.Text = num.ToString();

        }

        private void decBtn_Click(object sender, EventArgs e)
        {

            if(num > 0)
            {
                num--;
            }
            else
            {
                num = 0;
            }
            
            sharesTBox.Text = num.ToString();

        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {



        }

        private void webTBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void webBtn_Click(object sender, EventArgs e)
        {
        
            webBrowser.Navigate("https://finviz.com/quote.ashx?t=" + webTBox.Text, null, null, "User-Agent: Here Put The User Agent");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void changePortBtn_Click(object sender, EventArgs e)
        {

            String NewcsvLocation;

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {

                ofd.InitialDirectory = directory;

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //csvLocTBox.Text = ofd.FileName;
                    NewcsvLocation = ofd.FileName;
                }
            }

        }

        private void viewPortBtn_Click(object sender, EventArgs e)
        {



        }

        private void mkPortBtn_Click(object sender, EventArgs e)
        {

            createPortfolioForm open = new createPortfolioForm(name, directory);
            open.Show();

        }


        /*
         * 
         * var quote_service = new QuoteService();

            String ticker = this.tickerTBox.Text;

            var quote = quote_service.Quote(ticker).Return(QuoteReturnParameter.Open);

            //Console.WriteLine("{0}", quote.Open);

            MessageBox.Show("{0}", quote.Open);
         * 
         * 
         * 
        */


    }

    public class Portfolio
    {
        public string  Ticker   { get; set; }
        public string  Shares   { get; set; }
        public string  TotalMon { get; set; }
    }

}
