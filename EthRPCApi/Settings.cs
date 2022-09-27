namespace BlockchainRestAPI
{
	/// <summary>
	/// Wrapper for appsettings.json
	/// </summary>
    public static class Settings
    {
		private static Uri rcpURL;
		/// <summary>
		/// RPC Url of Geth
		/// </summary>
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
					} else
					{
						throw new IndexOutOfRangeException("Unable to find Geth URL in appsettings");
					}
				}

				return Settings.rcpURL;

			}
			set { rcpURL = value; }
		}




	}
}
