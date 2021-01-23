using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace ComProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int l = input.Text.Length; //input length
            int r = 0; //redundent terms
            string datain = input.Text;

            //find the No of R
            while (true)
            {
                if (l + r + 1 <= Math.Pow(2, r))
                {
                    break;
                }
                r++;
            }
            //add it to total length
            l += r;
            char[] datahammed = new char[l]; //hammed array list
            var datacount = 0;
            //prepare for hamming
            for (int i = 0; i < l; i++)
            {
                if (IsPowerOfTwo(i + 1))
                {
                    datahammed[i] = 'r';

                }
                else
                {
                    datahammed[i] = datain[input.Text.Length - 1 - datacount];
                    datacount++;
                }
            }
            //replacing r
            for (int i = 0; i < datahammed.Length; i++)
            {
                if (datahammed[i].Equals('r'))
                {
                    setR(i + 1, datahammed);
                }
            }

            hammed.Clear();
            for (int i = 0; i < datahammed.Length; i++)
            {
                hammed.Text += datahammed[i];
            }
            //here hammed data is ready 
            //adding errors
            var err = datahammed;
            if (e1.Checked)
            {
                var x = new Random();
                var rand = x.Next(l);
                if (err[rand].Equals('1'))
                {
                    err[rand] = '0';

                }
                else
                {
                    err[rand] = '1';
                }

                //correction
                string dec = "";
                char[] errCorrect = new char[l];
                Array.Copy(err, errCorrect, l);
                for (int i = 0; i < datahammed.Length; i++)
                {
                    if (IsPowerOfTwo(i + 1)||i==0)
                    {
                        dec += check(i + 1, errCorrect);

                    }
                }
               //dedection
                int errorpos = Convert.ToInt32(Reverse(dec), 2);
                errorL.Text = "At " + (errorpos);
                if (err[l-errorpos].Equals('1'))
                {
                    errCorrect[l-errorpos ] = '0';

                }
                else
                {
                    errCorrect[l-errorpos ] = '1';
                }
                corrected.Clear();
                for (int i = 0; i < datahammed.Length; i++)
                {
                    corrected.Text += errCorrect[i];
                }

            }
            else if (e2.Checked)
            {
                var x = new Random();
                var rand1 = x.Next(l);
                var rand2 = x.Next(l);
                while (rand1 == rand2)
                {
                    rand2 = x.Next(l);
                }
                if (err[rand1].Equals('1'))
                {
                    err[rand1] = '0';

                }
                else
                {
                    err[rand1] = '1';
                }
                if (err[rand2].Equals('1'))
                {
                    err[rand2] = '0';
                }
                else
                {
                    err[rand2] = '1';
                }
                errorL.Text = "Double";
                corrected.Text = "#######";

            }
            recieved.Clear();
            for (int i = 0; i < datahammed.Length; i++)
            {
                recieved.Text += err[i];
            }
        }
        bool IsPowerOfTwo(int x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }
        void setR(int index, char[] data)
        {
            var count = 0;
            for (int i = index; i < data.Length; i++)
            {
                if (data[i].Equals('r'))
                {
                    continue;
                }
                if (index == 1)
                {
                    if (i % 2 == 0)
                    {
                        count += Int32.Parse(data[i].ToString());
                    }
                }
                else
                {
                    var str = Convert.ToString(i + 1, 2);
                    if (str[str.Count() - 1 - (int)Math.Log(index, 2)] == '1')
                    {
                        count += Int32.Parse(data[i].ToString());
                    }
                }

            }
            if (count % 2 == 1)
                data[index - 1] = '1';
            else
                data[index - 1] = '0';

        }
        int check(int index, char[] data)
        {
            var count = 0;
            for (int i = index; i < data.Length; i++)
            {
                var str = Convert.ToString(i, 2);
                if (str[str.Count() - 1 - (int)Math.Log(index, 2)] == '1')
                {
                    count += Int32.Parse(data[i].ToString());
                }
            }
            if (count % 2 ==0)
                return 0;
            else
                return 1;
        }
        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
