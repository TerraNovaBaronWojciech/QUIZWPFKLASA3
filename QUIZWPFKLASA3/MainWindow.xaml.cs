using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Formats.Asn1.AsnWriter;

namespace QUIZWPFKLASA3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Quiz> quizList;
        private int currentIndex = 0;
        private int score = 0;
        private bool answerChecked = false;
        public MainWindow()
        {
            InitializeComponent();
            LoadQuiz();
            ShowQuestion();
        }
        private void LoadQuiz()
        {
            string path = "Quiz.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                quizList = JsonSerializer.Deserialize<List<Quiz>>(json);
            }
        }

        private void ShowQuestion()
        {
            if (currentIndex >= quizList.Count)
            {
                QuestionText.Text = $"Koniec! Twój wynik: {score} / {quizList.Count}";
                AnswerList.Visibility = Visibility.Collapsed;
                return;
            }

            var q = quizList[currentIndex];
            QuestionText.Text = q.Pytanie;
            AnswerList.ItemsSource = q.Odpowiedzi.Select(kv => $"{kv.Key}. {kv.Value}");
            AnswerList.SelectedIndex = -1;
            ResultText.Text = "";

        }
        private void CheckAnswer_Click(object sender, RoutedEventArgs e)
        {
            //tutaj ma być logika, która sprawdza pytania i przydziela punkty
        }
        private void NextAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (answerChecked)
            {
                answerChecked = false;
                currentIndex++;
                ShowQuestion();
            }
        }
    }
}
