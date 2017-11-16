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

                //Console.WriteLine("{0}", csvReader.GetField("tsla"));

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
            float quote;
            string checkcsvloc;
            int shares;
            float totalinvest;
            float appendtotalinvest;


            String ticker = this.tickerTBox.Text.Replace(" ", "");


            if (ticker == null)
            {
                MessageBox.Show("Ticker box is empty");
                return;
            }
            else
            {
                quote = quote_service.Quote(ticker).Return(QuoteReturnParameter.Open);
            }

            if (sharesTBox.Text != "0")
            {

                checkcsvloc = checkTicker(csvLoc, ticker);

                if (checkcsvloc != null)
                {

                    var strLines = File.ReadLines(csvLoc);
                    foreach (var line in strLines)
                    {
                        if (line.Split(',')[1].Equals(ticker))
                        {

                            
                            shares = Int32.Parse(line.Split(',')[2]) + Int32.Parse(this.sharesTBox.Text);
                            totalinvest = float.Parse(line.Split(',')[3]) + (quote * float.Parse(this.sharesTBox.Text));
                            


                            line.Split(',')[2] = shares.ToString();
                            line.Split(',')[3] = totalinvest.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Something when wrong with buy a share\n");
                            return;

                        }
                    }
                }
                else
                {
                    appendtotalinvest = quote * float.Parse(this.sharesTBox.Text);


                    using (var textWriter = new StreamWriter(csvLoc, append: true))
                    using (var csvWrite = new CsvWriter(textWriter))
                    {

                        var data = new[]
                        {
                        new Portfolio {Ticker = tickerTBox.Text, Shares = sharesTBox.Text, TotalMon = appendtotalinvest.ToString() }
                        };


                        csvWrite.Configuration.Delimiter = ",";
                        csvWrite.Configuration.HasHeaderRecord = false;
                        csvWrite.Configuration.AutoMap<Portfolio>();


                        csvWrite.WriteRecords(data);
                        textWriter.Flush();


                    }

                }         
            }
            else
            {

                MessageBox.Show("You cannot buy 0 or less shares");
                return;

            }

        }

        private void sellBtn_Click(object sender, EventArgs e)
        {

            var quote_service = new QuoteService();
            float quote;
            string checkcsvloc;
            int shares;
            float totalinvest;

            String ticker = this.tickerTBox.Text.Replace(" ", "");


            if (ticker == null)
            {
                MessageBox.Show("Ticker box is empty");
                return;
            }
            else
            {
                quote = quote_service.Quote(ticker).Return(QuoteReturnParameter.Open);
            }

            if (sharesTBox.Text != "0")
            {

                checkcsvloc = checkTicker(csvLoc, ticker);

                if (checkcsvloc != null)
                {

                    var strLines = File.ReadLines(csvLoc);
                    foreach (var line in strLines)
                    {
                        if (line.Split(',')[1].Equals(ticker))
                        {


                            shares = Int32.Parse(line.Split(',')[2]) - Int32.Parse(this.sharesTBox.Text);
                            totalinvest = float.Parse(line.Split(',')[3]) - (quote * float.Parse(this.sharesTBox.Text));



                            line.Split(',')[2] = shares.ToString();
                            line.Split(',')[3] = totalinvest.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Something when wrong with buy a share\n");
                            return;

                        }
                    }
                }
                else
                {

                    MessageBox.Show("You currently do not own any shares in thsi company");
                    return;

                }
            }
            else
            {

                MessageBox.Show("You cannot buy 0 or less shares");
                return;

            }

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

            viewPortfolioForm open = new viewPortfolioForm(csvLoc);
            open.Show();

        }

        private void mkPortBtn_Click(object sender, EventArgs e)
        {

            createPortfolioForm open = new createPortfolioForm(name, directory);
            open.Show();

        }

        private string updateHeader(string cash, string portVal)
        {
            string cashPortVal = "";




            return cashPortVal;
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

        string checkTicker(string file, string ticker)
        {
            string confirm="";

            var strLines = File.ReadLines(file);
            foreach (var line in strLines)
            {
                if (line.Split(',')[1].Equals(ticker))
                {

                    //return line.Split(',')[2];
                    //return (boolvar == '1');
                    confirm = "1";

                }                  
                else
                {
                    confirm = null;
                }
            }

            return confirm;
       
        }

/*
        string GetAddress(string file)
        {
            var strLines = File.ReadLines("filepath.csv");
            foreach (var line in strLines)
            {
                if (line.Split(',')[1].Equals(searchName))
                    return line.Split(',')[2];
            }

            return "";
        }
*/
    }

    public class Portfolio
    {
        public string  Ticker   { get; set; }
        public string  Shares   { get; set; }
        public string  TotalMon { get; set; }
    }

}