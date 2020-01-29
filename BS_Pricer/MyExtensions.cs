using NCalc;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace BlackSholesPricer
{
    /// <remarks>
    /// This class uses the NCalc library in order to evaluate user typed arithmetic expression in textbox
    /// </remarks>
    public static class MyExtensions
    {
        public static double? GetDecimalValueFromText(this TextBoxBase textBoxBase)
        {
            try
            {
                switch (textBoxBase)
                {
                    case MaskedTextBox mtb:
                        if (double.TryParse(mtb.Text.Replace(" ", ""), NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out double result))
                            return result;
                        return null;
                    case TextBox textBox:
                        return Convert.ToDouble(new Expression(textBox.Text).Evaluate());
                }
            }
            catch
            { return null; }
            return null;
        }
    }
}
