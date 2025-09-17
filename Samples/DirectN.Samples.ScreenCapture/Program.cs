namespace DirectN.Samples.ScreenCapture;

internal class Program
{
    static void Main()
    {
        using var app = new CompositionApplication();
        using var win = new ScreenCaptureWindow();
        var monitor = win.GetMonitor(MONITOR_FROM_FLAGS.MONITOR_DEFAULTTONEAREST)!;
        win.ResizeClient(monitor.WorkingArea.Width * 3 / 4, monitor.WorkingArea.Height * 3 / 4);
        win.Center();
        win.Show();
        win.SetForeground();
        app.Run();
    }
}
