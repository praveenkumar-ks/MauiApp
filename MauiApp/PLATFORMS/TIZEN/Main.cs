using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace $safeprojectname$;

class Program : MauiApplication
{
	protected override $safeprojectname$ CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
