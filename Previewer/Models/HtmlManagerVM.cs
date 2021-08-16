using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

namespace Previewer.Models
{
    public class HtmlManagerVM
    {
        public int Id { get; set; }

        public string TextHtml { get; set; }

        public string Url { get; set; } 
    }
}
