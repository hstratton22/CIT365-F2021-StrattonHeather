using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();

        // These integer variables store the numbers 
        // for the addition problem. 
        int addend1;
        int addend2;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        //for date
       // DateTime currentDate = DateTime.Now;

        // This integer variable keeps track of the 
        // remaining time.
        int timeLeft;

        //handles numChecker updown
        //public event EventHandler ValueChanged;

        public Form1()
        {
           
            InitializeComponent();
                     
        }
        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            //date
            dateLabel.Text = DateTime.Now.ToString("dd MMMM yyyy");// dd MM

            // Start the timer.
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();


        }

        /// <summary>
        /// Starts quiz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            //System.Media.SystemSounds.Beep.Play();
            startButton.Enabled = false;
        }
        /// <summary>
        /// Checks for all correct answers and stops timer and displays message or continues countdown
        /// until 5 seconds which then changes times background. Displays correct answers if not solved by user at finish.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            
            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() return false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
                 if (timeLeft <= 5)
                {
                    timeLabel.BackColor = Color.Red;
                }
            }
            else
            {
                // If the user ran out of time, stop the timer, show 
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                timeLabel.BackColor = Color.White;
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }
        /// <summary>
        /// Check the answer to see if the user got everything right.
        /// </summary>
        /// <returns>True if the answer's correct, false otherwise.</returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
       && (minuend - subtrahend == difference.Value)
        && (multiplicand * multiplier == product.Value)
        && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Check if any answer is correct
        /// </summary>
        /// <returns></returns>
        private bool CheckAnyAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
       || (minuend - subtrahend == difference.Value)
        || (multiplicand * multiplier == product.Value)
        || (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        
        /// <summary>
        /// Checks full length of response
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

       

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }
       /// <summary>
       /// check addition answer
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void checkForPlus(object sender, EventArgs e)
        {
            if(addend1 + addend2 == sum.Value)
                System.Media.SystemSounds.Beep.Play();

        }
        /// <summary>
        /// check subtraction answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkForSubtract(object sender, EventArgs e)
        {
             if (minuend - subtrahend == difference.Value)
                System.Media.SystemSounds.Beep.Play();
         
        
        }
        /// <summary>
        /// check multiplication answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkForMultiply(object sender, EventArgs e)
        {
            if (multiplicand * multiplier == product.Value)
                System.Media.SystemSounds.Beep.Play();
        }
        /// <summary>
        /// check division answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkForDivide(object sender, EventArgs e)
        {
            if (dividend / divisor == quotient.Value)
                     System.Media.SystemSounds.Beep.Play();
        }
    }
}
