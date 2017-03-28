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
        public Form1()
        {
            InitializeComponent();
            result result1 = new result();
            KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(test_KeyDown);
        }

        // kam posilat cisla, ve forme '3'?
        // jak posilat operace * + -
        // po kazde operaci nacist displayvalue
        // kopirovai z display value ale psat se tam nemuze

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // numeric keyboard
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                string pressedKey = e.KeyCode.ToString().Remove(0, 6);
                resultBox.Text = pressedKey;
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
            //result.AddNumber();
            string pressedNumber = ((Button)sender).Name.Remove(0, 3);
            resultBox.Text = pressedNumber;
        }
    

        private void addOperation(object sender, EventArgs e)
        {

        }

        private void calculate(object sender, EventArgs e)
        {

        }

        private void delete(object sender, EventArgs e)
        {

        }

        
    }
}
