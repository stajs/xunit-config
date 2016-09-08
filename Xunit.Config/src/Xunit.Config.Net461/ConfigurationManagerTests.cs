using System;
using System.Configuration;
using static System.Console;

namespace Xunit.Config.Net461
{
	public class ConfigurationManagerTests
	{
		[Fact]
		public void CanReadAppConfig()
		{
			WriteLine("AppDomain.CurrentDomain.SetupInformation.ConfigurationFile: " + AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
			var appSettings = ConfigurationManager.AppSettings;
			WriteLine("appSettings: " + (appSettings == null ? "null" : "not null"));
			WriteLine("appSettings[\"Foo\"]: " + appSettings["Foo"]);
			Assert.NotNull(ConfigurationManager.AppSettings);
			Assert.Equal("Bar", appSettings["Foo"]);
		}
	}
}
