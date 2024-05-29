namespace DirectN.Samples.MinimalD3D11;

internal static class Program
{
    static void Main()
    {
        using var app = new Application();
        using var win = new SampleWindow("minimal d3d11 pt3 by d7samurai - .NET 8 AOT");
        win.ResizeClient(1000, 1000);
        win.Center();
        win.Show();
        win.SetForeground();
        app.Run();
    }
}