using System;
using System.Configuration;

namespace Postcodesio
{
    public static class AppConfigReader
    {
        public static readonly String BaseUrl = ConfigurationManager.AppSettings["base_url"];

    }
}
