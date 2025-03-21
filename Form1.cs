using Knapsack;
namespace WinKnap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(numberBox.Text, out int q) ||
               !int.TryParse(seedBox.Text, out int s) ||
               !int.TryParse(capacityBox.Text, out int c))
            {
                MessageBox.Show("Wprowadü poprawne liczby!", "B≥πd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Problem problem = new Problem(q, s);
                Result result = problem.Solve(c);
                foreach (string line in result.ToString().Split(new[] { "\r\n", "\n" }, StringSplitOptions.None))
                {
                    resultBox.Items.Add(line);
                }

                foreach (string line in problem.ToString().Split(new[] { "\r\n", "\n" }, StringSplitOptions.None))
                {
                    instanceBox.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystπpi≥ b≥πd: {ex.Message}", "B≥πd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
