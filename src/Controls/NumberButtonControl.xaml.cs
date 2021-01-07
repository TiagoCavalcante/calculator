using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace Calculator.Controls
{
	public sealed partial class NumberButtonControl : UserControl
	{
		// dependencies
		public string Value
		{
			get { return (string)GetValue(ValueProperty); }
			set { SetValue(ValueProperty, value); }
		}

		public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(string), typeof(NumberButtonControl), null);

		// default functions
		public NumberButtonControl()
		{
			InitializeComponent();
		}

		// handle functions
		private void handleClick(object sender, RoutedEventArgs e)
		{
			TextBlock primaryDisplay = MainPage.mainPage.primaryDisplay;
			TextBlock secondaryDisplay = MainPage.mainPage.secondaryDisplay;
			TextBlock errorDisplay = MainPage.mainPage.errorDisplay;

			// the number can't have more than 6 digits
			if (primaryDisplay.Text.Length < 6)
			{
				if (secondaryDisplay.Text.Length + primaryDisplay.Text.Length <= 50)
				{
					primaryDisplay.Text += (sender as Button).Content;
				}
				else
				{
					errorDisplay.Text = "The exp. can have until 50 digits.";
					FlyoutBase.ShowAttachedFlyout(primaryDisplay);
				}
			}
			else
			{
				errorDisplay.Text = "The number can have until 6 digits.";
				FlyoutBase.ShowAttachedFlyout(primaryDisplay);
			}
		}
	}
}