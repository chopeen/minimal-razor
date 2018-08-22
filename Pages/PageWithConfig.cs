using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace minimal_razor.Pages
{
    public class PageWithConfig : PageModel
    {
        // injecting the configuration into the model
        public readonly IConfiguration Configuration;

        public PageWithConfig(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
    }
}
