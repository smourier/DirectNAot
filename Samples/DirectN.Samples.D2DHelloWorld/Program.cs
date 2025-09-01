namespace DirectN.Samples.D2DHelloWorld;

internal static class Program
{
    static void Main()
    {
        using var app = new Application();
        using var win = new D2DHelloWorldWindow();
        win.ResizeClient(800, 600);
        win.Center();
        win.Show();
        win.SetForeground();
        app.Run();
    }
}