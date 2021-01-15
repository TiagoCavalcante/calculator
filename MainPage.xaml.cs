using System;
using System.Data;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace Calculator
{
	public sealed partial class MainPage : Page
	{
		// default var
		public static MainPage mainPage { get; set; }

		// utils
		public int executeExpression(string text)
		{
			string number = new DataTable().Compute(text, "").ToString();
			double numberDouble = Convert.ToDouble(number);

			return Convert.ToInt16(numberDouble);
		}

		// default functions
		public MainPage()
		{
			InitializeComponent();

			mainPage = this;
		}

		// page functions
		private void pageLoaded(object sender, RoutedEventArgs e)
		{
			// window minimum size
			ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(256, 384));

			CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
			// title bar customization
			ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;

			titleBar.ButtonBackgroundColor = Windows.UI.Colors.Transparent;
			titleBar.ButtonInactiveBackgroundColor = Windows.UI.Colors.Transparent;
		}

		private void handleClearButtonClick(object sender, RoutedEventArgs e)
		{
			primaryDisplay.Text = "";
			secondaryDisplay.Text = "";
		}

		private void handleEqualButtonClick(object sender, RoutedEventArgs e)
		{
			try
			{
				primaryDisplay.Text = executeExpression(secondaryDisplay.Text + primaryDisplay.Text).ToString();

				if (primaryDisplay.Text.Length > 6)
					primaryDisplay.FontSize = 48;
				secondaryDisplay.Text = "";
			}
			catch
			{
				errorDisplay.Text = "There's an error in the exp.";
				FlyoutBase.ShowAttachedFlyout(primaryDisplay);
			}
		}
	}
}