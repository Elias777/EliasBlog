using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EliasBlog.Database
{
    [StructLayout(LayoutKind.Explicit, Size = 10032, CharSet = CharSet.Unicode, Pack = 1)]
    public struct XBlog
    {
        [MarshalAs(UnmanagedType.U4)]
        [FieldOffset(0)]
        public uint ID;

        //4 bts
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        [FieldOffset(8)]
        public string Title;

        // 2 bts
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5001)]
        [FieldOffset(32)]
        public string Blog;
    }
}
