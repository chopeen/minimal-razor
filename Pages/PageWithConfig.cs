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
    }
}
