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
          //tutaj ma być logika odpowiadająca za wyświetlanie pytania

        }
        private void CheckAnswer_Click(object sender, RoutedEventArgs e)
        {
            //tutaj ma być logika, która sprawdza pytania i przydziela punkty
        }
        private void NextAnswer_Click(object sender, RoutedEventArgs e)
        {
            //tutaj ma być logika, przenosi do kolejnego pytania
        }
    }
}