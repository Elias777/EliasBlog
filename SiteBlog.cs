using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpServer;

namespace EliasBlog
{
    public class SiteBlog : Page
    {
        public override CacheLevel CacheLevel
        {
            get { return CacheLevel.NoCache; }
        }
        public override PageType PageType
        {
            get { return PageType.Once; }
        }
        public override bool CanAccessDirectly
        {
            get { return true; }
        }
        public override bool FilterBefore
        {
            get { return true; }
        }
        public override bool FilterAfter
        {
            get { return false; }
        }
        public override bool EnableHooking
        {
            get { return true; }
        }
        public override string URL
        {
            get { return null; }
        }
        public override string TemplateAddr
        {
            get { return null; }
        }
        public override string Host
        {
            get { return "127.0.0.1"; }
        }
        public override uint CacheTime
        {
            get { return 0; }
        }
        public override ushort AccessLevel
        {
            get { return 0; }
        }
        public static void OnLoad()
        {
            Logger.ConsoleLog("Blog loaded!");
        }

        public override bool PreInit(Client client)
        {
            return true;
        }
    }
}
