using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static DevLynx.NetworkManager.NET.Platforms.Win32.NetListMgr;

namespace DevLynx.NetworkManager.NET.Extensions
{
    internal static class COMExtensions
    {
        public static void Advise<T>(this IConnectionPointContainer container, T sink, out int cookie)
        {
            Guid guid = typeof(INetworkListManagerEvents).GUID;
            container.FindConnectionPoint(ref guid, out var point);

            point.Advise(sink, out cookie);
        }

        public static void Unadvise(this IConnectionPointContainer container, object sink, ref int cookie)
        {
            container.Unadvise(sink, ref cookie);
        }
    }
}
