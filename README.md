# NetworkManager.NET
![preview](./assets/logo.png)

Crossplatform Network Manager for .NET

## Target Platforms
☑ Windows

☐ Linux

☐ Android

☐ IOS

☐ Tizen 


## Getting Started
```csharp
using DevLynx.NetworkManager.NET;

NetworkManager.Instance.Connected += (s, e) =>
{
    Console.WriteLine("Connection detected");
};

NetworkManager.Instance.Disconnected += (s, e) =>
{
    Console.WriteLine("Disconnection detected");
};

NetworkManager.Instance.Start();
```
Samples can be found in the [sample folder](/samples/).



## Potential Implementation sources:

### Linux
https://stackoverflow.com/questions/46909762/c-library-for-receiving-network-interface-up-down-notification-with-interface
https://cgit.freedesktop.org/NetworkManager/NetworkManager/tree/examples/C/glib/monitor-nm-state-gdb

### Windows
https://learn.microsoft.com/en-gb/windows/win32/sens/system-event-notification-service-portal?redirectedfrom=MSDN
https://learn.microsoft.com/en-gb/windows/win32/wmisdk/example--receiving-event-notifications-through-wmi-?redirectedfrom=MSDN
https://devblogs.microsoft.com/scripting/how-can-i-be-notified-any-time-a-network-cable-gets-unplugged/

### Android
https://developer.android.com/training/monitoring-device-state/connectivity-status-type

### IOS
https://stackoverflow.com/questions/14876733/iphone-notification-when-wifi-network-changes

### Tizen
https://docs.tizen.org/application/native/tutorials/feature/app-connectivity-usage/
