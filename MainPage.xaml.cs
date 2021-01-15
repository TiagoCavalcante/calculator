using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Calculator
{
	public sealed partial class MainPage : Page
	{
		// default var
		public static MainPage mainPage { get; set; }

		private void keyPress(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
		{
			if ((e.Key >= Windows.System.VirtualKey.Number0 && e.Key <= Windows.System.VirtualKey.Number9) || (e.Key >= Windows.System.VirtualKey.NumberPad0 && e.Key <= Windows.System.VirtualKey.NumberPad9))
			{
				int number;

				if (e.Key >= Windows.System.VirtualKey.Number0 && e.Key <= Windows.System.VirtualKey.Number9)
					number = e.Key - Windows.System.VirtualKey.Number0;
				else
					number = e.Key - Windows.System.VirtualKey.NumberPad0;

				Utils.Utils.handleClick(number.ToString());
			}
			else if (e.Key == Windows.System.VirtualKey.Escape)
			{
				Utils.Utils.handleClearButtonClick();
			}
			else if (e.Key == Windows.System.VirtualKey.Enter)
			{
				Utils.Utils.handleEqualButtonClick();
			}
			else if (e.Key == (Windows.System.VirtualKey)111 || e.Key == (Windows.System.VirtualKey)191)
			{
				Utils.Utils.handleOperationClick("/");
			}
			else if (e.Key == (Windows.System.VirtualKey)106)
			{
				Utils.Utils.handleOperationClick("*");
			}
			else if (e.Key == (Windows.System.VirtualKey)107)
			{
				Utils.Utils.handleOperationClick("+");
			}
			else if (e.Key == (Windows.System.VirtualKey)109)
			{
				Utils.Utils.handleOperationClick("-");
			}
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

			// enable title bar full customiztion
			CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
			// title bar customization
			ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;

			titleBar.ButtonBackgroundColor = Windows.UI.Colors.Transparent;
			titleBar.ButtonInactiveBackgroundColor = Windows.UI.Colors.Transparent;
			titleBar.ButtonInactiveForegroundColor = Windows.UI.Colors.White;
		}

		private void handleClearButtonClick(object sender, RoutedEventArgs e)
		{
			Utils.Utils.handleClearButtonClick();
		}

		private void handleEqualButtonClick(object sender, RoutedEventArgs e)
		{
			Utils.Utils.handleEqualButtonClick();
		}
	}
}