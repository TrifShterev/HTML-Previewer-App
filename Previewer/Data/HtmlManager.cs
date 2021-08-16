using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Previewer.Data
{
    public class HtmlManager
    {
        [Key]
        public int Id { get; set; }
        public string TextHtml { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastEditedOn { get; set; }
        [Url]
        public string Url { get; set; }
    }
}
