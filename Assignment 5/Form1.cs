namespace Assignment_5
{
    public partial class Form1 : Form
    {
        private int numberOfGuesses = 0;
        private int checkTheNumber(String number)
        {
            try {
                int checkedNumber = Int16.Parse(number);
                if(checkedNumber >= 0 && checkedNumber <= 100)
                {
                    return checkedNumber;
                }
                else
                {
                    textBox2.Text = "Your number is not in the right range";
                    return -1;
                }
            }
            catch
            {
                textBox2.Text = "You haven't written a number";
                return -1;
            }
        }

        private String checkUserInputWithRandomNumber(int userNubmer, int randomNumber)
        {
            if(userNubmer > randomNumber)
            {
                return String.Format("Your number is greater than the computer guessed number{0}", "📈");
            }
            else if(userNubmer < randomNumber)
            {
                return String.Format("Your number is lower than the computer guessed number{0}", "📉");
            }
            else
            {
                numberOfGuesses += 1;
                return String.Format("Congrutulations! Your number is the same as computer's one{0}. Your number of gueses was {1}", "🥇", numberOfGuesses);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userChoiceNumber = textBox1.Text;
            int checkednumber = checkTheNumber(userChoiceNumber);
            if (checkednumber != -1)
            {
                Random r = new Random();
                int computerRandomNuber = r.Next(0, 100);

                textBox2.Text = checkUserInputWithRandomNumber(checkednumber, computerRandomNuber);
            }
        }
    }
}