using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create a new list of intergeres called questions numbers
        //This intergers will hold how many questions we have for this quize and we will
        //shuffle this inside the start game function

        List<int> questionNumbers = new List<int> { 1, 2, 3, 4 ,5,6,7,8,9,10};
        //Create 3 more intergers called qNum that will control which question show //on the scree, i and score
        int qNum = 0;
        int i;
        int score;
        public MainWindow()
        {
            InitializeComponent();
            //inside of the main cionstructor we will run the start game and next question function

           
            
        }
        private void RestartGame()
        {
            //restart game, function wil load all of the default values for this game
            score = 0;
            qNum = -1;
            i = 0;
            StartGame(); //there is no function for this yet
        }
        private void StartGame()
        {
            score = 0;
            qNum = -1;

        }
        private void checkAnswer(object Sender,RoutedEventArgs e)
        {
            //note that this is for checking the answer even, this even is linked to each button on the canvas when either it to a local button will be pressed we will run this even
            Button SenderButton = Sender as Button;// firts check which button sent this event to link it to a local button inside of this event
            //in the i statement below, we will check if th button clicked on has a 1 tag inside of it, if it does then we will add 1 to the score
            if (SenderButton.Tag.ToString()=="1")
            {
                score++;
            }
            //if the qnum is less that 0 the we will resert qnum interger to 0
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                //if the qnum is greatr than 0 then we will add 1 to the qnum integer
                qNum++;
            }
            //update the score tect label each time the buttons are pressed
            scoreText.Content = "Answer Correnctly " + score + "/" + questionNumbers.Count;

            //Run the next question function
            NextQuestion();
                  

        }
        private void NextQuestion()
        {
            //This function will check whicj qustion to show next and it will have all of the questionnd and answer definitions in the is statement below it will be checking if the qNum integer is less tahta the total number of the questions if it then will set the values of i to the valu of qNum
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                //if we habe done below the numcber of the quesions we have available then we will restart the game
                RestartGame();
            }
            //Below we are running  foreach loop where will check each button inside of the canvas and whern we find them set their tag to 0 and background to dark salmon color
            foreach (var x in myCancas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }
            switch (i)
            {
                case 1:
                    txtQuestion.Text = "How long does it take to be a qualified Software Developer ?";
                    //each of the buttons can have thier own answers in this game
                    ans1.Content = "1 Year";
                    ans2.Content = "Depends";
                    ans3.Content = "2 Years";
                    ans4.Content = "None";
                    ans2.Tag = "1";

                    //Here we will load the 1st image inside of the qimage
                    qImage.Source = new BitmapImage(new Uri(@"Pictures/Depends.png", UriKind.Relative));
                    //qImage.Source = new BitmapImage(new Uri(@"pack:// application:,,, /Joshua Door.jpg"));
                    break;
                case 2:
                    txtQuestion.Text = "What is the common IDE that can be used to code C# ?";
                    //each of the buttons can have thier own answers in this game
                    ans1.Content = "Visual Studio";
                    ans2.Content = "SQL Server Management Studio Only";
                    ans3.Content = "Visual Studio Code";
                    ans4.Content = "NotePad++";

                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"Pictures/Visual Studio.png", UriKind.RelativeOrAbsolute));
                    break;
                case 3:
                    txtQuestion.Text = "How long should it take to master C# ?";
                    //each of the buttons can have thier own answers in this game
                    ans1.Content = "Study Once a month";
                    ans2.Content = "Study Once a week";
                    ans3.Content = "Practice everyday";
                    ans4.Content = "Watch Videos everyday and do not =bother to code";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(@"Pictures/what-is-csharp.png", UriKind.RelativeOrAbsolute));
                    break;
                case 4:
                    txtQuestion.Text = "What other Programming Languages can i Learn ?";
                    //each of the buttons can have thier own answers in this game
                    ans1.Content = "English";
                    ans2.Content = "Sciences";
                    ans3.Content = "Java";
                    ans4.Content = "Mathematics";

                    ans3.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"Pictures/Java.png", UriKind.RelativeOrAbsolute));
                    break;


                case 5:
                    txtQuestion.Text = "What value can be asssigned to integer value ?";
                    //each of the buttons can have thier own answers in this game
                    ans1.Content = 2;
                    ans2.Content = "Sciences";
                    ans3.Content = 2.5;
                    ans4.Content = "Mathematics";
                   

                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"Pictures/Integers.png", UriKind.RelativeOrAbsolute));
                    break;

                case 6:
                    txtQuestion.Text = "What value can be assigned to a string ?";
                    //each of the buttons can have thier own answers in this game
                    ans1.Content = 2;
                    ans2.Content = "Sciences";
                    ans3.Content = 2.5;
                    ans4.Content = false;


                    ans2.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"Pictures/String.png", UriKind.RelativeOrAbsolute));
                    break;

                case 7:
                    txtQuestion.Text = "Picture dipecting a boolean ?";
                    //each of the buttons can have thier own answers in this game
                    ans1.Content = 2;
                    ans2.Content = "Sciences";
                    ans3.Content = 2.5;
                    ans4.Content = false;


                    ans4.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"Pictures/Boolean.png", UriKind.RelativeOrAbsolute));
                    break;

                case 8:
                    txtQuestion.Text = "Is Prgramming gender based ?";
                    //each of the buttons can have thier own answers in this game
                    ans1.Content ="Maybe" ;
                    ans2.Content = "False";
                    ans3.Content = "True";
                    ans4.Content = "Yes";


                    ans2.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"Pictures/Codding.png", UriKind.RelativeOrAbsolute));
                    break;

                case 9:
                    txtQuestion.Text = "How do Software Developers work ?";
                    //each of the buttons can have thier own answers in this game
                    ans1.Content = "However";
                    ans2.Content = "Individually";
                    ans3.Content = " 1 and 2";
                    ans4.Content = "Teams";


                    ans4.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"Pictures/Teams.png", UriKind.RelativeOrAbsolute));
                    break;

                case 10:
                    txtQuestion.Text = "what makes a good Team Leader ?";
                    //each of the buttons can have thier own answers in this game
                    ans1.Content = "Selfishness";
                    ans2.Content = "Sharing knowledge";
                    ans3.Content = "Looking down on others";
                    ans4.Content = "Disagree with everything";


                    ans2.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"Pictures/GoodLeader.png", UriKind.RelativeOrAbsolute));
                    break;


            
        }

        }
            
        
    }
}
