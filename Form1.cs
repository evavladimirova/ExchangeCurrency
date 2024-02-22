namespace ExchangeCurrency
{
    public partial class Form1 : Form
    {
        private double lastConvertedResult = 0;
        private CurrencyConverter converter = new CurrencyConverter();
        public Form1()
        {
            InitializeComponent();
        }

        private void toEuroRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toBGNRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {

            if (double.TryParse(inputTextBox.Text, out double amount))
            {
                if (toEuroRadioButton.Checked)
                {
                    //BGN to EUR
                    lastConvertedResult = converter.ConvertToEuro(amount);
                }
                else if (toBGNRadioButton.Checked)
                {
                    //EUR to BGN
                    lastConvertedResult = converter.ConvertToBGN(amount);
                }

                resultLable.Text = $"{amount} {(toEuroRadioButton.Checked ? "BGN" : "EUR")} is {lastConvertedResult:F2} {(toEuroRadioButton.Checked ? "EUR" : "BGN")}";
            }
            else
            {
                resultLable.Text = "Please enter a valid numeric amount.";
            }
        }

        private void resultLable_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
     
            lastConvertedResult = 0;
            resultLabel.Text = string.Empty;
            inputTextBox.Text = string.Empty;
            toBGNRadioButton.Checked = false;
            toEuroRadioButton.Checked = false;
        }
    }
    public class CurrencyConverter
    {
        private const double ExchangeRate = 1.95583;

        public double ConvertToEuro(double amount)
        {
            return amount / ExchangeRate;
        }

        public double ConvertToBGN(double amount)
        {
            return amount * ExchangeRate;
        }
    }
}
