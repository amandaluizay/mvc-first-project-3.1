using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace dev.appModelo.Extension
{
   //criando tag helper de email
    public class EmailTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            //atribuindo o output para ancora
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            //criando variavel com o domínio do email
            var target = content.GetContent() + "@" + "desenvolvedor.io";
            //atribuindo domínio
            output.Attributes.SetAttribute("href", "mailto:" + target);
            output.Content.SetContent(target);
        }
    }
}
