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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> numbers;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            numbers = new List<int>();
            string[] strings = txtBoxInput.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (string str in strings)
                {
                    int number;

                    if (!int.TryParse(str, out number))
                    {
                        MessageBox.Show("The numbers are invalid");

                        return;
                    }
                    numbers.Add(number);
                }

                if (numbers.Count == 0)
                    return;

                numbers.Sort();

                if (sortingComboBox.Text != "from smallest to largest")
                    numbers.Reverse();

                txtBlockSum.Text = numbers.Sum().ToString();
                txtBlockSmallest.Text = numbers.Min().ToString();
                txtBlockLargest.Text = numbers.Max().ToString();
                txtBlockArithmetic.Text = numbers.Average().ToString();
                txtBlockSorted.Text = string.Join(" ", numbers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Xatolik bor:" + ex.Message);
            }

        }



    }
}