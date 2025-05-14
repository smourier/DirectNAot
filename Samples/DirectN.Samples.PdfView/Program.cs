namespace DirectN.Samples.PdfView;

internal class Program
{
    static void Main()
    {
        using var app = new CompositionApplication();

        WindowSynchronizationContext.Install(); // ensure we have a UI-thread bound synchronization context for async calls

        using var win = new PdfViewWindow();
        var monitor = win.GetMonitor(MONITOR_FROM_FLAGS.MONITOR_DEFAULTTONEAREST)!;
        win.ResizeClient(monitor.WorkingArea.Width * 3 / 4, monitor.WorkingArea.Height * 3 / 4);
        win.Center();
        win.Show();
        win.SetForeground();
        app.Run();
    }
}
