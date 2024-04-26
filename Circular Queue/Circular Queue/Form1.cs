using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circular_Queue
{
    public partial class Form1 : Form
    {
        string[] Queued = new string[10];
        int Head = 0; int Tail = 0;int Count = 0;
        int[] ints = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Count < 10)
            { 
                Queued[Tail] = TextBoxSupreme.Text;
                Tail =  ints[Array.IndexOf(ints, Tail) + 1];
                Count++;
                TextBoxSupreme.Text = "";
            }
            CountDisplay.Text = (Count + "/10");
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Count > 0)
            {
                Queued[Head] = "";
                Head = ints[Array.IndexOf(ints, Head) + 1];
                Count--;
                TextBoxSupreme.Text = Queued[Head];
                
            }
            CountDisplay.Text = (Count + "/10");
        }
    }
}
