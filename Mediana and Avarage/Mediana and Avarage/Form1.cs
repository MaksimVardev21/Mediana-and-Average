using System.Globalization;

namespace Mediana_and_Avarage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string[] inputNumbers = textBox1.Text.Split(' ');

            List<double> numbers = new List<double>();
            foreach (string input in inputNumbers)
            {
                if (double.TryParse(input, out double number))
                {
                    numbers.Add(number);
                }
            }


            double median = CalculateMedian(numbers);
            double averageNumbers = numbers.Average();
            mediana.Text = $"Median: {median}";
            average.Text = $"Average: {averageNumbers}";
        }
        private double CalculateMedian(List<double> numbers)
        {
            numbers.Sort();
            double media = 0;
            if (numbers.Count % 2 == 1)
            {
                media = numbers[(numbers.Count - 1) / 2];
            }
            if (numbers.Count % 2 == 0)
            {
                var index = numbers.Count / 2;
                media = (numbers[index] + numbers[index - 1]) / 2.0;
            }
            return media;
        }
    }
}