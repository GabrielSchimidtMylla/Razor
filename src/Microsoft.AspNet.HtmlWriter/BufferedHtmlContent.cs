using System;
using System.IO;
using Microsoft.Framework.Internal;
using Microsoft.Framework.WebEncoders;

namespace Microsoft.AspNet.HtmlWriter
{
    public class BufferedHtmlContent : IHtmlContent
    {
        private BufferEntryCollection _buffer;

        public void WriteTo(TextWriter writer, IHtmlEncoder encoder)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            var writer = new StringWriter();
            WriteTo(writer, new HtmlEncoder());
            return writer.ToString();
        }
    }
}