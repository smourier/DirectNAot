namespace DirectN.Samples.HelloWorld;

internal static class Program
{
    static void Main()
    {
        using var app = new Application();
        using var win = new Window("Hello World");
        win.ResizeClient(800, 600);
        win.Center();
        win.Show();
        win.SetForeground();
        app.Run();
    }
}