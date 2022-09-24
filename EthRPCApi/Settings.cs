namespace EthRPCApi
{
	/// <summary>
	/// Wrapper for appsettings.json
	/// </summary>
    public static class Settings
    {
		private static Uri rcpURL;

		public static Uri RcpURL
		{
			get
			{
				if (Settings.rcpURL == null)
				{
					var setting = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetValue("GethRPC", String.Empty);
					if(setting != null)
					{
						Settings.rcpURL = new Uri(setting);
					}
				}

				return Settings.rcpURL;

			}
			set { rcpURL = value; }
		}




	}
}
