﻿namespace MvvmShellCalc;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("MainPage",typeof(MainPage));
	}

	
}
