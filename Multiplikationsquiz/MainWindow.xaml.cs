using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Multiplikationsquiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Quiz quiz;
        private Stopwatch sw;
        public MainWindow()
        {
            InitializeComponent();
            this.quiz = new Quiz();
            this.sw = new Stopwatch();
        }

        private void on_new_quiz(object sender, RoutedEventArgs e)
        {
            quiz.Next();
            evaluationBox.Content = null;
            timeBox.Content = null;
            questionBox.Content = quiz.Frage;
            sw.Reset();
            sw.Start();
        }

        private void on_check(object sender, RoutedEventArgs e)
        {
            if (quiz.Answer == Convert.ToInt32(anwserBox.Text))
            {
                sw.Stop();
                evaluationBox.Content = "✔";
                timeBox.Content = sw.Elapsed;
            } else
            {
                evaluationBox.Content = "❌";
                anwserBox.Text = null;
            }
        }
    }
}