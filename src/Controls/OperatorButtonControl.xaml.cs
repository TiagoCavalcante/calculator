using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Calculator.Controls
{
	public sealed class OperatorButtonControl : UserControl
	{
		// dependencies
		public string Value
		{
			get { return (string)GetValue(ValueProperty); }
			set { SetValue(ValueProperty, value); }
		}

		// utils
		public bool isNumeric(char character)
		{
			if (int.TryParse(character.ToString(), out _))
				return true;
			else
				return false;
		}


		public static readonly DependencyProperty ValueProperty =
			DependencyProperty.Register("Value", typeof(string), typeof(NumberButtonControl), null);

		// default function
		public OperatorButtonControl()
		{
			InitializeComponent();
		}

		// handle functions
		private void handleClick(object sender, RoutedEventArgs e)
		{
			TextBlock primaryDisplay = MainPage.mainPage.primaryDisplay;
			TextBlock secondaryDisplay = MainPage.mainPage.secondaryDisplay;

			if (primaryDisplay.Text.Length + secondaryDisplay.Text.Length < 50)
			{
				if (secondaryDisplay.Text.Length != 0)
				{
					if (!isNumeric(secondaryDisplay.Text[secondaryDisplay.Text.Length - 1]) && primaryDisplay.Text.Length == 0)
						secondaryDisplay.Text = secondaryDisplay.Text.Substring(0, secondaryDisplay.Text.Length - 1) + (sender as Button).Content;
					else
						secondaryDisplay.Text += primaryDisplay.Text + (sender as Button).Content;
				}
				else if (primaryDisplay.Text.Length != 0)
					secondaryDisplay.Text += primaryDisplay.Text + (sender as Button).Content;
				primaryDisplay.Text = "";
			}
		}
	}
}