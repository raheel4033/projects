using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Project_DS
{

    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        AlgorithmSelector aS = new AlgorithmSelector();
        public char KeyChar { get; set; }
        private int[] _arr;
        private int[] _resultArr;
        private readonly Random _random;
        private readonly Stopwatch _stopwatch;

        public Form2()
        {
            _stopwatch = new Stopwatch();
            _random = new Random();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ResetAll();
        }
        public void ResetAll()
        {
            lstArray.Items.Clear();
            this.txtSize.Text = "1000";
            this.txtMin.Text = "1";
            this.txtMax.Text = "1000";

            this.txtBubble.Text = string.Empty;
            this.txtCount.Text = string.Empty;
            this.txtHeap.Text = string.Empty;
            this.txtMerge.Text = string.Empty;
            this.txtQuick.Text = string.Empty;
            this.txtSelection.Text = string.Empty;

        }
        public void GenerateResultArray()
        {
            if (_arr == null)
            {
                initArray();
            }
            _resultArr = new int[_arr.Length];
            Array.Copy(_arr, _resultArr, _arr.Length);
            aS.Arr = _resultArr;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstArray.Items.Clear();
            if (_arr!=null)
            {
                for (int i = 0; i < _arr.Length; i++)
                {
                    lstArray.Items.Add(_arr[i]);
                }
            }
            lstArray.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GenerateResultArray();
            _stopwatch.Start();
            aS.BubbleSort();
            txtBubble.Text = _stopwatch.Elapsed.ToString();
            _stopwatch.Reset();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lstArray.Items.Clear();
            if (_resultArr!=null)
            {
                for (int i = 0; i < _resultArr.Length; i++)
                {
                    lstArray.Items.Add(_resultArr[i]);
                }
                lstArray.Visible = true;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            GenerateResultArray();
            _stopwatch.Start();
            aS.SelectionSort();
            _stopwatch.Stop();
            txtSelection.Text = _stopwatch.Elapsed.ToString();
            _stopwatch.Reset();
        }
        
        private void button2_Click_2(object sender, EventArgs e)
        {
            GenerateResultArray();
            _stopwatch.Start();
            aS.HeapSort(aS.Arr);
            _stopwatch.Stop();
            txtHeap.Text = _stopwatch.Elapsed.ToString();
            _stopwatch.Reset();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            GenerateResultArray();
            _stopwatch.Start();
            aS.MergeSort(aS.Arr, 0, aS.Arr.Length - 1);
            _stopwatch.Stop();
            txtMerge.Text = _stopwatch.Elapsed.ToString();
            _stopwatch.Reset();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;

        }
        private void txtMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;

        }
        private void txtMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;

        }
        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {
            var tempbox = txtSize;
            int value;
            if (int.TryParse(tempbox.Text, out value))
            {
                if (value > 50000)
                {
                    tempbox.Text = "500000";
                }
                else if (value < 10)
                {
                    tempbox.Text = "10";
                }
            }
        }
        private void button2_Click_3(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            GenerateResultArray();
            _stopwatch.Start();
            aS.QuickSort(aS.Arr, 0, aS.Arr.Length - 1);
            _stopwatch.Stop();
            txtQuick.Text = _stopwatch.Elapsed.ToString();
            _stopwatch.Reset();
        }

        private void btnCounting_Click(object sender, EventArgs e)
        {
            GenerateResultArray();
            _stopwatch.Start();
            _resultArr = aS.CountingSort(aS.Arr);
            _stopwatch.Stop();
            txtCount.Text = _stopwatch.Elapsed.ToString();
            _stopwatch.Reset();
        }
       

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            initArray();
        }
        public void initArray()
        {
            _arr = new int[int.Parse(txtSize.Text)];
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = _random.Next(int.Parse(txtMin.Text), int.Parse(txtMax.Text));
            }
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            var textbox = txtMin;
            int value;
            if (int.TryParse(textbox.Text,out value))
            {
                if (value>50000)
                {
                    textbox.Text = "100000";
                }
                else if (value<1)
                {
                    textbox.Text = "1";
                }
            }
            int maxVal;
            int.TryParse(txtMax.Text, out maxVal);
            if (value > maxVal)
            {
                btnSubmit.Enabled = false;
                btnBubble.Enabled = false;
                btnCounting.Enabled = false;
                btnHeap.Enabled = false;
                btnMerge.Enabled = false;
                btnQuick.Enabled = false;
                btnSelection.Enabled = false;
                label4.Visible = true;
            }
            else
            {
                btnSubmit.Enabled = true;
                btnBubble.Enabled = true;
                btnCounting.Enabled = true;
                btnHeap.Enabled = true;
                btnMerge.Enabled = true;
                btnQuick.Enabled = true;
                btnSelection.Enabled = true;
                label4.Visible = false;
            }
               
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            var textbox = txtMax;
            int value;
            if (int.TryParse(textbox.Text, out value))
            {
                if (value > 50000)
                {
                    textbox.Text = "100000";
                }
                else if (value < 1)
                {
                    textbox.Text = "1";
                }
            }
            int minVal;
            int.TryParse(txtMax.Text, out minVal);
            if (value < minVal)
            {
                btnSubmit.Enabled = false;
                btnBubble.Enabled = false;
                btnCounting.Enabled = false;
                btnHeap.Enabled = false;
                btnMerge.Enabled = false;
                btnQuick.Enabled = false;
                btnSelection.Enabled = false;
                label4.Visible = true;
            }
            else
            {
                btnSubmit.Enabled = true;
                btnBubble.Enabled = true;
                btnCounting.Enabled = true;
                btnHeap.Enabled = true;
                btnMerge.Enabled = true;
                btnQuick.Enabled = true;
                btnSelection.Enabled = true;
                label4.Visible = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
