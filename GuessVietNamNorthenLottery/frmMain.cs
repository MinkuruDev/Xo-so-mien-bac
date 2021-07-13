using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessVietNamNorthenLottery
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSpecial.Text = lblG1.Text = lblG2.Text = lblG3.Text
                = lblG4.Text = lblG5.Text = lblG6.Text = lblG7.Text = " ";
        }

        private string guess(int number, int digit)
        {
            int range = (int) Math.Pow(10, digit);
            Random random = new Random();
            string result = "";

            for(int i = 0; i<number; i -= -1)
            {
                int temp = random.Next(range);
                string tmp = string.Format("{0,5:D5}", temp);
                result += tmp.Substring(tmp.Length - digit) + ((number == 6 && i == 2) ? "\n" : "     "); 
            }

            result = result.TrimEnd();
            return result;
        }

        private void guess()
        {
            lblSpecial.Text = guess(1, 5);
            lblG1.Text = guess(1, 5);
            lblG2.Text = guess(2, 5);
            lblG3.Text = guess(6, 5);
            lblG4.Text = guess(4, 4);
            lblG5.Text = guess(6, 4);
            lblG6.Text = guess(3, 3);
            lblG7.Text = guess(4, 2);
        }

        private string guessCode()
        {
            DateTime ABCodeDay = DateTime.Parse("3/30/2021 6:9: 6AM",
                          System.Globalization.CultureInfo.InvariantCulture);
            List<string> code = new List<string>();
            for(char i = 'A'; i<='Z'; i++)
            {
                for(char j = 'A'; i<='Z'; j++)
                {

                }
            }
            return "AB";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if((dateTimePicker1.Value.Date - DateTime.Today).TotalDays < 0)
            {
                MessageBox.Show("Ngày đã qua\nHãy chọn lại ngày");
                return;
            }else if ((dateTimePicker1.Value.Date - DateTime.Today).TotalDays == 0)
            {
                if(dateTimePicker1.Value.Hour > 18)
                {
                    MessageBox.Show("Giờ vàng đã qua\nHãy chọn ngày tới để dự đoán");
                    return;
                }
            }

            guess();
        }
    }
}
