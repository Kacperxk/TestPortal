using static System.Formats.Asn1.AsnWriter;

namespace TestPortal
{
    public partial class Form1 : Form
    {
        public class Question
        {
            public string Text { get; }
            public string[] Choices { get; }
            public string Answer { get; }

            public Question(string text, string[] choices, string answer)
            {
                Text = text;
                Choices = choices;
                Answer = answer;
            }
        }

        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            LoadQuestionsFromFile("questions.txt");
            DisplayQuestion(currentQuestionIndex);
        }

        private void LoadQuestionsFromFile(string fileName)
        {
            questions = new List<Question>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 6) // Ensure all fields are present
                        {
                            string questionText = parts[0];
                            string[] choices = { parts[1], parts[2], parts[3], parts[4] };
                            string correctAnswer = parts[5];
                            Question question = new Question(questionText, choices, correctAnswer);
                            questions.Add(question);
                        }
                        else
                        {
                            MessageBox.Show("Invalid question format: " + line);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading file: " + e.Message);
            }
        }


        private void DisplayQuestion(int index)
        {
            if (index >= 0 && index < questions.Count)
            {
                Question currentQuestion = questions[index];
                questionLabel.Text = currentQuestion.Text;
                radioButtonA.Text = currentQuestion.Choices[0];
                radioButtonB.Text = currentQuestion.Choices[1];
                radioButtonC.Text = currentQuestion.Choices[2];
                radioButtonD.Text = currentQuestion.Choices[3];

                questionNumberLabel.Text = "Pytanie " + (index + 1) + "/" + questions.Count;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                DisplayQuestion(currentQuestionIndex);
            }
            else
            {
                MessageBox.Show("Koniec! Twój wynik to: " + score + "/" + questions.Count);
                Close();
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            currentQuestionIndex--;
            if (currentQuestionIndex >= 0)
            {
                DisplayQuestion(currentQuestionIndex);
            }
            else
            {
                currentQuestionIndex = 0;
            }
        }

        private void CheckAnswer()
        {
            Question currentQuestion = questions[currentQuestionIndex];
            RadioButton selectedRadioButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (selectedRadioButton != null)
            {
                string selectedAnswer = selectedRadioButton.Text.Substring(0, 1);
                if (selectedAnswer == currentQuestion.Answer)
                {
                    score++;
                }
            }
        }
    }
}