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

        List<Label> labelResultList = new List<Label>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
                result += tmp.Substring(tmp.Length - digit) + ((number == 6 && i == 2) ? "\n" : "   "); 
            }

            result = result.TrimEnd();
            return result;
        }

        private string guess()
        {
            double d = (DateTime.Now - dateTimePicker1.Value.Date).TotalDays;
            return d.ToString();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            label11.Text = guess();
        }
    }
}
