using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SmartRdo.MVC.TagHelpers
{
    public class CreateButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string emailTo = context.AllAttributes["mailTo"].Value.ToString();
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + emailTo);
            output.Content.SetContent("Envie-nos um email");
        }
    }
}
