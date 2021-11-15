using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;

namespace GR953500.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    //[HtmlTargetElement("user")]
    public class UserTagHelper : TagHelper
    {
        public int UserId { get; set; }
        LinkGenerator _lg;
        public UserTagHelper(LinkGenerator lg)
        {
            _lg = lg;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var url=_lg.GetPathByAction("UserInfo","Home", new {id=UserId});
            output.TagName = "a";
            output.Attributes.Add("class", "btn btn-info");
            output.Attributes.Add("href", url);
            output.Content.SetHtmlContent("Show user Info");
        }
    }
}
