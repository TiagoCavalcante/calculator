﻿#pragma checksum "D:\Users\Projects\UWP\UWP\Calculator\App.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D7DDDA7882E03C51AA19BF1AC219FB2"

namespace Calculator
{
#if !DISABLE_XAML_GENERATED_MAIN
	public static class Program
	{
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		static void Main(string[] args)
		{
			global::Windows.UI.Xaml.Application.Start((p) => new App());
		}
	}
#endif

	partial class App : global::Windows.UI.Xaml.Application
	{
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
		private bool _contentLoaded;
		/// <summary>
		/// InitializeComponent()
		/// </summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public void InitializeComponent()
		{
			if (_contentLoaded)
				return;

			_contentLoaded = true;
#if DEBUG && !DISABLE_XAML_GENERATED_BINDING_DEBUG_OUTPUT
			DebugSettings.BindingFailed += (sender, args) =>
			{
				global::System.Diagnostics.Debug.WriteLine(args.Message);
			};
#endif
#if DEBUG && !DISABLE_XAML_GENERATED_BREAK_ON_UNHANDLED_EXCEPTION
			UnhandledException += (sender, e) =>
			{
				if (global::System.Diagnostics.Debugger.IsAttached) global::System.Diagnostics.Debugger.Break();
			};
#endif
		}
	}
}