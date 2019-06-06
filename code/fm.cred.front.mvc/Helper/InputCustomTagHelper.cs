using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace fm.cred.front.mvc.Helper {
    [HtmlTargetElement ("input-custom")]
    public class InputCustomTagHelper : TagHelper {
        private const string EmailDomain = "contoso.com";

        // Can be passed via <email mail-to="..." />.
        // PascalCase gets translated into kebab-case.
        public string MailTo { get; set; }

        public override void Process (TagHelperContext context, TagHelperOutput output) {
            output.TagName = "a"; // Replaces <email> with <a> tag

            var address = MailTo + "@" + EmailDomain;
            output.Attributes.SetAttribute ("href", "mailto:" + address);
            output.Content.SetContent (address);
        }
    }
}