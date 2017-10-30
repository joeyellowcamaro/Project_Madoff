using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YSQ.core.Quotes;

namespace Project_Madoff
{
    public partial class applicationForm : Form
    {

        public applicationForm()
        {
            InitializeComponent();
        }

        private void applicationForm_Load(object sender, EventArgs e)
        {

        }

        private void tickerTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sharesBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var quote_service = new QuoteService();

            String ticker = this.tickerTBox.Text;

            var quote = quote_service.Quote(ticker).Return(QuoteReturnParameter.Open);

            //Console.WriteLine("{0}", quote.Open);

            MessageBox.Show("{0}", quote.Open);

        }
    }
}
