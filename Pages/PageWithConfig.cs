using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace minimal_razor.Pages
{
    public class PageWithConfig : PageModel
    {
        // injecting the configuration and logger into the model
        public readonly IConfiguration Configuration;
        public readonly ILogger<PageWithConfig> Logger;

        public PageWithConfig(IConfiguration configuration, ILogger<PageWithConfig> logger)
        {
            this.Configuration = configuration;
            this.Logger = logger;
        }

        public void OnGet()
        {
            this.Logger.LogInformation("Entered the `OnGet` function.");

            try
            {
                // deliberate error to force an exception
                int zero = 0;
                int error = 1/zero;
            }
            catch (DivideByZeroException ex)
            {
                this.Logger.LogCritical(ex, "Division by 0 is still not possible.");
            }
        }
    }
}
