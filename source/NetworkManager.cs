using DevLynx.NetworkManager.NET.Platforms.Win32;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DevLynx.NetworkManager.NET
{
    public interface INetworkManager
    {
        public bool IsActive { get; }
        public bool IsConnected { get; }

        public event EventHandler Connected;
        public event EventHandler Disconnected;
    }

    public abstract class NetworkManager : INetworkManager
    {
        public abstract event EventHandler Connected;
        public abstract event EventHandler Disconnected;

        public abstract bool IsActive { get; }
        public abstract bool IsConnected { get; }

        static NetworkManager _instance;
        public static NetworkManager Instance
        {
            get
            {
                if (_instance is not null)
                    return _instance;

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    _instance = new Win32NetworkManager();
                }

                return _instance;
            }
        }

        internal NetworkManager() { }

        public abstract void Start();
        public abstract void Stop();
    }
}