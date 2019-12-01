using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Cafedebug.Web.TagHelpers
{
    /// <summary>
    /// Classe TagHelper para configuração do href email
    /// </summary>
    public class EmailTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "debugcafe";
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + "gmail.com";
            output.Attributes.SetAttribute("href", "mailto:" + target);
            output.Content.SetContent(target);

        }
    }
}
