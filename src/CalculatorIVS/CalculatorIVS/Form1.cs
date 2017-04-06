using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OurMathLib;


namespace CalculatorIVS
{
    public partial class Form1 : Form
    {
        Result result1;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            result1 = new Result();
            
        }

        // po kliku buttonek zustane oznaceny

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // numeric keyboard
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                char[] pressedKey = e.KeyCode.ToString().Remove(0, 6).ToCharArray();
                result1.AddNumber(pressedKey[0]);
                update();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                result1.SetOperation("div");
                update();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                result1.SetOperation("mul");
                update();
            }
            else if (e.KeyCode == Keys.Add)
            {
                result1.SetOperation("add");
                update();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                result1.SetOperation("sub");
                update();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                result1.ApplyOperation();
                update();
            }
            else if(e.KeyCode == Keys.Back)
            {
                result1.Revert();
                update();
            }
            //else if (e.KeyCode >= Keys.D0 && e.KeyCode >= Keys.D9) // non-numeric BUG - TODO
            //{
            //    string pressedKey2 = e.KeyCode.ToString().Remove(0, 1);
            //    resultBox.Text = pressedKey2;
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addNumber(object sender, EventArgs e)
        {
            char[] pressedNumber = ((Button)sender).Name.Remove(0, 3).ToCharArray();
            if (pressedNumber[0] == 'd') { pressedNumber[0] = '.'; } // better pass 'd'?
            result1.AddNumber(pressedNumber[0]);
            update();
        }
    

        private void addOperation(object sender, EventArgs e)
        {
            result1.SetOperation(((Button)sender).Name.Remove(0, 3));
        }

        private void calculate(object sender, EventArgs e)
        {
            try
            {
                result1.ApplyOperation();
                update();
            }
            catch (Exception ex)
            {
                resultBox.Text = ex.Message;
            }
        }

        private void delete(object sender, EventArgs e)
        {
            string operaceMazani = ((Button)sender).Name.Remove(0, 3);
            if (operaceMazani == "delce")
                result1.Revert();
            else if (operaceMazani == "delc")
                result1.Reset();
            update();
        }

        private void update()
        {
            resultBox.Text = result1.GetDisplayValue().ToString();
            //result1.Focus();
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
