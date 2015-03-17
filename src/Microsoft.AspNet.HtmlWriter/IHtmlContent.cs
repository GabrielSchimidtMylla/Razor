using System.IO;
using Microsoft.Framework.WebEncoders;

namespace Microsoft.AspNet.HtmlWriter
{
    public interface IHtmlContent
    {
        void WriteTo(TextWriter writer, IHtmlEncoder encoder);
    }
}