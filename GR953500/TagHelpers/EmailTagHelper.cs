using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;
namespace GR953500.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        private string domain = "@mail.ru";
        // ссылка на атрибут mail-to
        public string MailTo { get; set; }
        LinkGenerator _linkGenerator;

        public EmailTagHelper(LinkGenerator linkGenerator)
        {
            _linkGenerator = linkGenerator;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var address = MailTo + domain;
            output.Attributes.Add("href", "mailto:" + address);
            output.Content.SetContent(address);            
        }
    }

}
