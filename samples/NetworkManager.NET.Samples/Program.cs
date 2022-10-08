// See https://aka.ms/new-console-;template for more information
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

Console.ReadLine();

