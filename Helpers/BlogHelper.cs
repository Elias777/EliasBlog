using EliasBlog.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XData;

namespace EliasBlog.Helpers
{
    public class BlogHelper
    {
        public XTable<XBlog> Table = new XTable<XBlog>();

        public BlogHelper()
        {

        }
    }
}
