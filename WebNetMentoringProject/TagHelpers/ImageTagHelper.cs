using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebNetMentoringProject.TagHelpers
{
    [HtmlTargetElement("image-taghelper")]
    public class ImageTagHelper : TagHelper
    {
        public string Url { get; set; }

        public int Size { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";
            output.TagMode = TagMode.SelfClosing;

            output.Attributes.Add("src", Url);
            output.Attributes.Add("height", Size);
            output.Attributes.Add("width", Size);
        }
    }
}
