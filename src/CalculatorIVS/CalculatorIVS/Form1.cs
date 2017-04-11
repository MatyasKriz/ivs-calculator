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
        /// <summary>
        /// Catches pressed keys.
        /// </summary>
        /// <param name="sender">Object which called the function.</param>
        /// <param name="e">The key which was sent.</param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // catches numeric keys
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                char[] pressedKey = e.KeyCode.ToString().Remove(0, 6).ToCharArray();
                result1.AddNumber(pressedKey[0]);
                update();
            } // catches the rest
            else if (e.KeyCode == Keys.Divide)
            {
                result1.SetOperation("div");
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                result1.SetOperation("mul");
            }
            else if (e.KeyCode == Keys.Add)
            {
                result1.SetOperation("add");
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                result1.SetOperation("sub");
            }
            else if(e.KeyCode == Keys.Enter)
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
            else if(e.KeyCode == Keys.Back)
            {
                result1.Revert();
                update();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Appends digit to the number displayed on the display.
        /// </summary>
        /// <param name="sender">Object which called the function.</param>
        /// <param name="e">The key which was sent.</param>
        private void addNumber(object sender, EventArgs e)
        {
            char[] pressedNumber = ((Button)sender).Name.Remove(0, 3).ToCharArray();
            if (pressedNumber[0] == 'd') { pressedNumber[0] = '.'; }
            result1.AddNumber(pressedNumber[0]);
            update();
        }
        /// <summary>
        /// Sets the operation the user is willing to do.
        /// </summary>
        /// <param name="sender">Object which called the function.</param>
        /// <param name="e">The key which was sent.</param>
        private void addOperation(object sender, EventArgs e)
        {
            result1.SetOperation(((Button)sender).Name.Remove(0, 3));
        }
        /// <summary>
        /// Sets the operation the user is willing to do and refreshes the displayed result immediately.
        /// </summary>
        /// <param name="sender">Object which called the function.</param>
        /// <param name="e">The key which was sent.</param>
        private void addOperationUpdate(object sender, EventArgs e)
        {
            try
            {
                result1.SetOperation(((Button)sender).Name.Remove(0, 3));
                update();
            }
            catch (Exception ex)
            {
                resultBox.Text = ex.Message;
            }

        }
        /// <summary>
        /// Calls ApplyOperation() after click on the '=' button.
        /// <param name="sender">Object which called the function.</param>
        /// <param name="e">The key which was sent.</param>
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
        /// <summary>
        /// Deletes the result and updates the display value.
        /// </summary>
        /// <param name="sender">Object which called the function.</param>
        /// <param name="e">The key which was sent.</param>
        private void delete(object sender, EventArgs e)
        {
            string operaceMazani = ((Button)sender).Name.Remove(0, 3);
            if (operaceMazani == "delce")
                result1.Revert();
            else if (operaceMazani == "delc")
                result1.Reset();
            update();
        }
        /// <summary>
        /// Updates the display value.
        /// </summary>
        private void update()
        {
            resultBox.Text = result1.GetDisplayValue().ToString();
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
