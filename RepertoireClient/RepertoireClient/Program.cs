using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace RepertoireClient
{
    public class Program
    {
        public static string parameters = "./properties.xml" ;

        public static void Main(string[] args)
        {
            try
            {
                string[] params_ = System.IO.File.ReadAllLines(parameters);

                for(int i = 0; i<params_.Length; i++)
                {
                    if (params_[i].Contains("<file>"))
                    {
                        Services.IO.Document = params_[i].Substring(params_[i].IndexOf('>')+1);
                        Services.IO.Document = Services.IO.Document.Substring(0, Services.IO.Document.IndexOf('<'));
                    }
                    else if (params_[i].Contains("<delimitter>"))
                    {
                        Services.IO.Delimitter = params_[i].Substring(params_[i].IndexOf('>')+1)[0];
                    }
                }

            }catch(Exception e)
            {
                System.IO.File.WriteAllLines(parameters, new string[] {
                    "<properties>",
                    "  <file></file>",
                    "  <delimitter>;</delimitter>",
                    "</properties>"});
            }

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
