namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        string currentEntry = "";
        int currentState = 1;
        double firstOperand, secondOperand;
        string mathOperator;

        public double Outcome { get; private set; }

        void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;
            currentEntry += pressed;

            this.text.Text += pressed;
        }

        void Clear(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentEntry = string.Empty;
            this.text.Text = string.Empty;
        }

        private void Operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;
            currentEntry += pressed;
            this.text.Text += pressed;
        }
        private double Operator() => mathOperator switch
        {
            "+" => firstOperand + secondOperand,
            "-" => firstOperand - secondOperand,
            "÷" => firstOperand / secondOperand,
            "X" => firstOperand * secondOperand,
            _ => throw new NotImplementedException(),
        };


        private void Result(object sender, EventArgs e)
        {
            if (mathOperator == "+")
            {
                Outcome = firstOperand + secondOperand;
            }
            else if (mathOperator == "-")
            {
                Outcome = firstOperand - secondOperand;
            }
            else if (mathOperator == "÷")
            {
                Outcome = firstOperand / secondOperand;
            }
            else if (mathOperator == "X")
            {
                Outcome = firstOperand * secondOperand;
            }
            this.text.Text = $"Outcome";
        }
    }


}
