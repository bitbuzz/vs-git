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

namespace vs_git_app
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private MyCalculator _myCalculator = new MyCalculator();

		public MainWindow()
		{
			InitializeComponent();
		}

		private int Add(List<int> values)
		{
			return _myCalculator.Add(values);
		}

		private int Subract(int a, int b)
		{
			return _myCalculator.Subract(a, b);
		}

		private int Divide(int a, int b)
		{
			return _myCalculator.Divide(a, b);
		}

		private int Multiply(int a, int b)
		{
			return _myCalculator.Multiply(a, b);
		}

		private string ConcatenateStrings(string a, string b)
		{
			return a + ", " + b;
		}

		private string ReverseString(string input)
		{
			char[] charArray = input.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}

		private void startBtn_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("3 times 4 reversed is " + ReverseString(Multiply(3, 4).ToString()) + "...");
		}
	}
}
