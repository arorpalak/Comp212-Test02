using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palak_Arora_Exercise03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IntegersRadioButton.Checked = true;

        }

        private async void btnCalculateFact_Click(object sender, EventArgs e)
        {
            //use of BigInteger to calculate factorial of bigger numbers.
            BigInteger n = new BigInteger(int.Parse(txtFact.Text));
            BigInteger fact = new BigInteger(1);
            txtAnswer.Text = "calculating";
            await Task.Run(() => {
                Thread.Sleep(1000);
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
            });
            txtAnswer.Text = fact.ToString();
        }

        private void CheckEvenOddButton_Click(object sender, EventArgs e)
        {
            int inputNumber = Int32.Parse(InputNumberTextBox.Text);
            if (inputNumber % 2 == 0)
            {
                MessageBox.Show(inputNumber + " is an Even Number");

            }
            else
            {
                MessageBox.Show(inputNumber + " is a Odd Number");
            }
       

        }

        private void GenerateValuesButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            GeneratedValuesListBox.Items.Clear();

            // generate integers between 10 and 99
            if (IntegersRadioButton.Checked)
            {
                int result;
                for (int counter = 1; counter <= 10; counter++)
                {
                    result = random.Next(10, 100);
                    GeneratedValuesListBox.Items.Add(result);
                }
            }
            // generate doubles with interval = random.NextDouble() * (maximum - minimum) + minimum;
            else if (DoublesRadioButton.Checked)
            {
                double result;
                for (int counter = 1; counter <= 10; counter++)
                {
                    result = random.NextDouble() * (99 - 10) + 10;
                    GeneratedValuesListBox.Items.Add(Math.Round(result, 2));
                }
            }
            // generate chars
            else if (CharRadioButton.Checked)
            {
                char result;
                for (int counter = 1; counter <= 10; counter++)
                {
                    result = (char)random.Next('A', 'Z');
                    GeneratedValuesListBox.Items.Add(result);
                }
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get a list from generated values
                List<string> list = GetListString();

                // Check if informed value is present using a generic search method
                bool isPresent = SearchData(list, InputSearchValueTextBox.Text);

                // Present result on MessageBox
                if (isPresent == true)
                {
                    MessageBox.Show("Informed value is present in the list.");
                }
                else
                {
                    MessageBox.Show("Informed value is NOT present in the list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "MESSAGE",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SearchData<T>(List<T> list, T searchValue) where T : IComparable<T>
        {
            bool result = false;
            foreach (var item in list)
            {
                if (item.CompareTo(searchValue) == 0)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }// end SearchData

        private List<string> GetListString()
        {
            // Create a list to store values present in the listBox
            List<string> list = new List<string>();

            // Populate list with listBox values
            for (int i = 0; i < GeneratedValuesListBox.Items.Count; i++)
            {
                list.Add(GeneratedValuesListBox.Items[i].ToString());
            }
            return list;
        }// end GetListString

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve user's input as an int
                int lowIndex = int.Parse(InputLowIndexTextBox.Text);
                int highIndex = int.Parse(InputHighIndexTextBox.Text);

                // Validate index values
                if (lowIndex < 0 || highIndex >= GeneratedValuesListBox.Items.Count || lowIndex > highIndex)
                {
                    throw new ArgumentOutOfRangeException();
                }

                // Get a list from generated values
                List<string> list = GetListString();

                Display(list, lowIndex, highIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "MESSAGE",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Display<T>(List<T> list, int low, int high) where T : IComparable<T>
        {
            List<T> between = new List<T>();

            // Populate a sublist between with values from low and high index
            for (int i = low; i <= high; i++)
            {
                between.Add(list[i]);
            }

            OutputValuesBetweenLowHighTextBox.Text = string.Empty;

            // Print values from sublist between
            foreach (var item in between)
            {
                OutputValuesBetweenLowHighTextBox.Text += item + " ";
            }
        }// end Display
    }
}
