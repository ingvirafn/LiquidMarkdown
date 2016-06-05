using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Markdown.Xaml
{
    public class MarkdownLiquid : Markdown
    {
        public override FlowDocument Transform(string text)
        {
            if (String.IsNullOrEmpty(text))
                return base.Transform(text);
            try
            {

                var tmp = DotLiquid.Template.Parse(text);
                var rdr = tmp.Render();
                return base.Transform(rdr);
            }
            catch (Exception e)
            {
                return base.Transform(text);
            }

        }
    }
}
