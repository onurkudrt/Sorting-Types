using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Sort sort = new Sort(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            string temp="";
         int[] array = { 1, 5, 7, 8, 14, 90, 44, 11, 56, 74, 3, 76, 106, 4, 0, 22 };
            for (int i = 0; i < array.Length; i++)
                temp += array[i].ToString() + " ";
            MessageBox.Show(temp);
            temp = "";
            sort.InsertionSort(array);
            for (int i = 0; i < array.Length; i++)
                temp += array[i].ToString() + " ";
            MessageBox.Show(temp);
        }
    }
}
