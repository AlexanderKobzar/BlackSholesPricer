using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackSholesPricer
{
    public partial class BlackSholesCalculatorForm : Form, IBlackSholesView
    {
        private readonly BlackScholesModel model;
        private readonly BlackSholesController controller;
        private static readonly ILog logger = LogManager.GetLogger(typeof(BlackSholesCalculatorForm));
        private List<TextBoxBase> controlsToValidate;

        public BlackSholesCalculatorForm()
        {
            InitializeComponent();
            IntializeEvents();

            controlsToValidate = new List<TextBoxBase>
            {maskedTextBox_S, maskedTextBox_K, textBox_t, maskedTextBox_sigma,maskedTextBox_r };

            model = new BlackScholesModel();
            controller = new BlackSholesController(model, this);
        }

        private void IntializeEvents()
        {
            maskedTextBox_S.Click += new System.EventHandler(this.MaskedTextBox_Click);
            maskedTextBox_K.Click += new System.EventHandler(this.MaskedTextBox_Click);
            textBox_t.Click += new System.EventHandler(this.MaskedTextBox_Click);
            maskedTextBox_sigma.Click += new System.EventHandler(this.MaskedTextBox_Click);
            maskedTextBox_r.Click += new System.EventHandler(this.MaskedTextBox_Click);

            maskedTextBox_S.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_KeyDown);
            maskedTextBox_K.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_KeyDown);
            maskedTextBox_sigma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_KeyDown);
            maskedTextBox_r.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_KeyDown);
        }

        public BlackSholesParams GetParams()
        {
            return new BlackSholesParams(maskedTextBox_S.GetDecimalValueFromText().Value,
                maskedTextBox_K.GetDecimalValueFromText().Value,
             textBox_t.GetDecimalValueFromText().Value,
               maskedTextBox_sigma.GetDecimalValueFromText().Value,
               maskedTextBox_r.GetDecimalValueFromText().Value);
        }

        public void ShowResults(double c, double d)
        {
            textBox_callOption.Text = c.ToString("F4");
            textBox_putOption.Text = d.ToString("F4");
        }

        private bool ValidateNumericControls()
        {
            bool allControlsValid = true;
            controlsToValidate.ForEach(x =>
            {
                if (x.GetDecimalValueFromText() == null)
                {
                    x.BackColor = Color.Red;
                    allControlsValid = false;
                }
                else
                    x.BackColor = Color.White;
            });
            return allControlsValid;
        }
        private void button_Price_Click(object sender, EventArgs e)
        {
            try
            {
                resultControls();
                if (ValidateNumericControls())
                    controller.Price();
            }
            catch (Exception exception)
            {
                logger.Error("Black-Sholes Pricing Error", exception);
                MessageBox.Show("An error occured during pricing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            void resultControls()
            {
                textBox_callOption.Text = string.Empty;
                textBox_putOption.Text = string.Empty;
            }
        }

        private void textBox_t_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip(textBox_t, "You can use arithmetic expressions, like 180 / 365");
        }

        //If a decimal separator is typed (comma or point) put the cursor just after the separator
        private void maskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is MaskedTextBox mtb && (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod))
                mtb.Select(mtb.Mask.IndexOf('.', 0), 0);
        }

        //Put the cursor at the beggining of the control if nothing is typed yet
        private void MaskedTextBox_Click(object sender, EventArgs e)
        {
            if (sender is MaskedTextBox mtb && mtb.GetDecimalValueFromText() == null)
                mtb.Select(0, 0);
        }
    }
}
