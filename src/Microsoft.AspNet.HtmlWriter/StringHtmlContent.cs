using System;
using System.IO;
using Microsoft.Framework.WebEncoders;

namespace Microsoft.AspNet.HtmlWriter
{
    public class StringHtmlContent : IHtmlContent
    {
        public static readonly StringHtmlContent Empty = new StringHtmlContent(string.Empty, encoded: true);

        private bool _encoded;
        private string _text;

        public StringHtmlContent FromEncodedText(string text)
        {
            return new StringHtmlContent(text, encoded: true);
        }

        public StringHtmlContent(string text)
            : this(text, encoded: false)
        {
        }

        private StringHtmlContent(string text, bool encoded)
        {
            _text = text;
            _encoded = encoded;
        }

        public void WriteTo(TextWriter writer, IHtmlEncoder encoder)
        {
            if (_encoded)
            {
                writer.Write(_text);
            }
            else
            {
                encoder.HtmlEncode(_text, writer);
            }
        }

        public override string ToString()
        {
            var writer = new StringWriter();
            WriteTo(writer, new HtmlEncoder());
            return writer.ToString();
        }
    }
}