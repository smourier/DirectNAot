namespace DirectN.Samples.D2DHelloWorld;

internal static class Program
{
    static void Main()
    {
        using var app = new Application();
        using var win = new D2DRenderWindow("Direct2D Hello World");
        win.ResizeClient(800, 600);
        win.Center();
        win.Show();
        win.SetForeground();

        var hsv = Hsv.From(D3DCOLORVALUE.Red);
        using var timer = new Timer(state =>
        {
            win.BackgroundColor = hsv.ToD3DCOLORVALUE();
            hsv.Hue += 10;
        }, null, 0, 100);

        app.Run();
    }
}