using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CalculatorLib;

namespace CalculatorWin
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            
        }

        private void rbSection_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked){
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                _1DRange.Enabled = false;
                btProcess1DArray100.Enabled = true;
                btProcess1DArrayGeneral.Enabled = false;
                
            }else if (radioButton2.Checked){
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                _1DRange.Enabled = true;
                btProcess1DArray100.Enabled = false;
                btProcess1DArrayGeneral.Enabled = true;

            }else if (radioButton3.Checked){
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }else{
                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }
        }

        private void btProcess1DArray100_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(_1DLength.Text);
            int search = Convert.ToInt32(_1DSearch.Text);
            int[] array = Calculator.generateArray(length);
            //ternal operand
            //variable = bool ? valueTrue : valueFalse;
            
            MessageBox.Show(process1DArray(length, 100, search));
        }

        private void btProcess1DArrayGeneral_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(_1DLength.Text);
            int range = Convert.ToInt32(_1DRange.Text);
            int search = Convert.ToInt32(_1DSearch.Text);
            MessageBox.Show(process1DArray(length, range, search));
        }

        private static string process1DArray(int length, int range, int search){
            int[] array = Calculator.generateArray(length, range);
            string s = "Write out:" + Environment.NewLine;
            s += Calculator.writeOut(array, "") + Environment.NewLine;
            s += "Write out backwards:" + Environment.NewLine;
            s += "Write out sorted:" + Environment.NewLine;
            s += Calculator.writeOut(Calculator.processSortAscensional(array), "") + Environment.NewLine;
            s += Calculator.writeOutBackward(array, "") + Environment.NewLine;
            s += "Process length: ";
            s += Calculator.processLength(array) + Environment.NewLine;
            s += "Process sum: ";
            s += Calculator.processSum(array) + Environment.NewLine;
            s += "Process ArAverage: ";
            s += Calculator.processArAverage(array) + Environment.NewLine;
            s += "Process max: ";
            s += Calculator.processMax(array) + Environment.NewLine;
            s += "Process min: ";
            s += Calculator.processMin(array) + Environment.NewLine;
            if (Calculator.processSearchFor(array, search))
                s += "Searched int is in the array" + Environment.NewLine;
            else
                s += "Searched int isn't in the array" + Environment.NewLine;
            return s;
            MessageBox.Show(s);
        }

        private void btProcess2DArray_Click(object sender, EventArgs e)
        {
            int columns = Convert.ToInt32(_2DColumnCount.Text);
            int rows = Convert.ToInt32(_2DRowCount.Text);

            double[,] array2D = Calculator.generateArray2D(rows, columns);
            MessageBox.Show(Calculator.writeOutGUI(array2D));
        }
    }
}
