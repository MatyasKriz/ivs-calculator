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
        result result1;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            result1 = new result();
        }
        // po kazde operaci nacist displayvalue
        // kopirovai z display value ale psat se tam nemuze
        // zakazat natahovani a zmencovani

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // numeric keyboard
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                char[] pressedKey = e.KeyCode.ToString().Remove(0, 6).ToCharArray();
                result1.AddNumber(pressedKey[0]);
                resultBox.Text = result1.GetDisplayValue().ToString();
                    //resultBox.Text = pressedKey[0].ToString();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                result1.SetOperation("div");
                resultBox.Text = result1.GetDisplayValue().ToString();
                    //resultBox.Text = "div";
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                result1.SetOperation("mul");
                resultBox.Text = result1.GetDisplayValue().ToString();
                    //resultBox.Text = "mul";
            }
            else if (e.KeyCode == Keys.Add)
            {
                result1.SetOperation("add");
                resultBox.Text = result1.GetDisplayValue().ToString();
                    //resultBox.Text = "plus";
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                result1.SetOperation("sub");
                resultBox.Text = result1.GetDisplayValue().ToString();
                    //resultBox.Text = "sub";
            }
            else if(e.KeyCode == Keys.Enter)
            {
                result1.ApplyOperation();
                resultBox.Text = result1.GetDisplayValue().ToString();
            }
            else if(e.KeyCode == Keys.Back)
            {
                result1.Revert();
            }
            else if (e.KeyCode >= Keys.D0 && e.KeyCode >= Keys.D9) // non-numeric BUG - TODO
            {
                string pressedKey2 = e.KeyCode.ToString().Remove(0, 1);
                resultBox.Text = pressedKey2;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addNumber(object sender, EventArgs e)
        {
            char[] pressedNumber = ((Button)sender).Name.Remove(0, 3).ToCharArray();
            result1.AddNumber(pressedNumber[0]);
            resultBox.Text = result1.GetDisplayValue().ToString();
        }
    

        private void addOperation(object sender, EventArgs e)
        {
            result1.SetOperation(((Button)sender).Name.Remove(0, 3));
            resultBox.Text = result1.GetDisplayValue().ToString();

        }

        private void calculate(object sender, EventArgs e)
        {
            result1.ApplyOperation();
            resultBox.Text = result1.GetDisplayValue().ToString();

        }

        private void delete(object sender, EventArgs e)
        {
            string operaceMazani = ((Button)sender).Name.Remove(0, 3);
            if (operaceMazani == "delce")
                result1.Revert();
            else if (operaceMazani == "delc")
                result1.Reset();
            else if (operaceMazani == "del") ;
                // remove last character;
        }

        
    }
}
