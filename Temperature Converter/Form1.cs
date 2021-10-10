using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class Form1 : Form
    {

        string activeTextBox; // a string that contains the name of the last textbox to be edited

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /* This method is called when the Convert button is clicked */
        private void Convert_Click(object sender, EventArgs e)
        {

            double temperatureInput; // a variable that stores the temperature to be converted

            try // Made with help from the textbook (Gaddis, 160)
            {
                // This switch determines which operation to perform depending on which was the last textbox to have been edited
                switch (activeTextBox)
                {
                    // this code block runs if the last textbox to be edited was the Fahrenheit textbox
                    case "Fahrenheit":
                        temperatureInput = Double.Parse(Fahrenheit.Text); // Converts the entry in the Fahrenheit textbox into a double. If this is not possible, an exception is caught
                        Celsius.Text = FormatResult(FahrenheitToCelsius(temperatureInput)); // converts the the entry in the Fahrenheit textbox to Celsius and displays the formatted result in the Celsius textbox
                        break;
                    // this code block runs if the last textbox to be edited was the Celsius textbox
                    case "Celsius":
                        temperatureInput = Double.Parse(Celsius.Text); // Converts the entry in the Celsius textbox into a double. If this is not possible, an exception is caught
                        Fahrenheit.Text = FormatResult(CelsiusToFahrenheit(temperatureInput)); // converts the the entry in the Celsius textbox to Fahrenheit and displays the formatted result in the Fahrenheit textbox
                        break;
                }
            }
            catch(Exception ex) // If the input cannot be parsed into a numeric data type, an exception will result. This displays the exception's message
            {
                MessageBox.Show(ex.Message); // Displays the exception's message
            }

            FormatResult(123.1);
        }

        /* This method is called when the Fahrenheit textbox is edited */
        private void Fahrenheit_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = "Fahrenheit"; // changes the activeTextBox variable to "Fahrenheit"
        }

        /* This method is called when the Celsius textbox is edited */
        private void Celsius_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = "Celsius"; // changes the activeTextBox variable to "Celsius"
        }

        /* Converts a double input from Fahrenheit to Celsius */
        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;  // uses the input in the formula to convert Fahrenheit to Celsius and returns the result. This formula comes from the textbook (Gaddis, 197).
        }

        /* Converts a double input from Celsius to Fahrenheit */
        private double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32; // uses the input in the formula to convert Celsius to Fahrenheit and returns the result. This formula comes from the textbook (Gaddis, 197).
        }

        // This method takes in a double method and formats it so that it contains 3 decimal places, returning the result as a string
        private string FormatResult(double number)
        {
            string decimalPlaces = ""; // A string variable representing the decimal places of the number
            string result = ""; // A string variable that will contain the eventual return value of the method

            // Adds the decimal places of the parameter to the decimalPlaces variable
            bool decimalPointDetected = false; // A boolean variable that will be set to true once the following for-loop reaches the decimal point in the parameter
            for(int i = 0; i < number.ToString().Length; i++) // This for-loop iterates once for every character in the parameter after it has been parsed into a string
            {
                if(!decimalPointDetected) // If the decimal point has not been detected yet, the loop should not add the current character to the decimalPlaces variable
                {
                    if(number.ToString()[i] == '.') // If the current character is a decimal point, set the decimalPointDetected variable to true
                    {
                        decimalPointDetected = true;
                    }
                }
                else // If the decimal point has been detected, each character afterward should be added to the decimalPlaces variable
                {
                    decimalPlaces += number.ToString()[i];
                }
            }

            // In order to be properly formatted, the result should have exactly three decimal places. If it has more or fewer then it must be rounded or zeroes must be added onto the end
            if(decimalPlaces.Length < 3) // If there are fewer than three decimal places then zeroes must be added until there are
            {
                while(decimalPlaces.Length < 3) // This loop iterates until the decimalPlaces variable has a length of 3
                {
                    decimalPlaces += "0"; // A zero is added to the decimalPlaces variable
                }
            } 
            else if(decimalPlaces.Length > 3) // If there are more than three decimal places then the parameter must be rounded
            {
                if(int.Parse(decimalPlaces[3].ToString()) >= 5) // If the fourth decimal place is greater than or equal to 5 then the third decimal place must be increased by 1
                {
                    decimalPlaces = decimalPlaces[0].ToString() + decimalPlaces[1] + (int.Parse(decimalPlaces[2].ToString()) + 1).ToString(); // Sets the decimalPlaces variable to the first three decimal places, adding 1 to the third
                }
                else // If the fourth decimal place is less than 5 then the third decimal place does not need to be increased
                {
                    decimalPlaces = decimalPlaces[0].ToString() + decimalPlaces[1] + decimalPlaces[2]; // Sets the decimalPlaces variable to the first three decimal places
                }
            }

            result = ((int)number).ToString() + "." + decimalPlaces; // Sets the result variable to a formatted string
            return result; // Returns the result variable
        }
    }
}

// References:
// Gaddis, T. (2020). Starting Out With Visual C#. Pearson.