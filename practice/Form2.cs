using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = rnd.Next();
            int x = 10;
            int i;
            
           
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();
            List<int> list4 = new List<int>();
            List<int> list5 = new List<int>();
            List<int> list6 = new List<int>();
            for (int j = 0; j < x; j++)
            {
                n = rnd.Next(-50, 50);
                list.Add(n);
            }
            for(i = 0; i < list.Count; i++)
            {
                if(list[i] < 0)
                {
                    list2.Add(list[i]);
                    if (list[i]> -10)
                    {
                        list4.Add(list[i]);
                    }
                    else
                    {
                        list5.Add(list[i]);
                    }

                }
                else if(list[i] > 0)
                {
                    list3.Add(list[i]);
                    if(list[i]> 10)
                    {
                        list5.Add(list[i]);
                    }
                    else
                    {
                        list4.Add(list[i]);
                    }
                }
            }
            for(i=0; i < list.Count; i++)
            {
                for(int j=i+1; j < list.Count; ++j)
                {
                    if (list[i] == list[j])
                    {
                        list6.Add(list[i]);
                    }
                }
            }

            listBox1.DataSource = list;
            listBox2.DataSource = list2;
            listBox3.DataSource = list3;
            listBox4.DataSource = list4;
            listBox5.DataSource = list5;
            listBox6.DataSource = list6;
            /*do
            {
                n = rnd.Next(-50, 50);
                    listBox1.Items.Add(n);
               
                   

            } while ((listBox1.Items.Count != x));
            */
        }
    }
}
