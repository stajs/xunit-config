using System;
using System.Configuration;

namespace Xunit.Config.Net461
{
	public class ConfigurationManagerTests
	{
		[Fact]
		public void CanReadAppConfig()
		{
			var appSettings = ConfigurationManager.AppSettings;
			Console.WriteLine("appSettings: " + (appSettings == null ? "null" : "not null"));
			Console.WriteLine("appSettings[\"Foo\"]: " + appSettings["Foo"]);
			Assert.NotNull(ConfigurationManager.AppSettings);
			Assert.Equal("Bar", appSettings["Foo"]);
		}
	}
}
