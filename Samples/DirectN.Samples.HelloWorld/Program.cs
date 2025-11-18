namespace DirectN.Samples.HelloWorld;

internal static class Program
{
    static void Main()
    {
        using var app = new Application();
        using var win = new MyWindow();
        win.ResizeClient(800, 600);
        win.Center();
        win.Show();
        win.SetForeground();
        app.Run();
    }
}

internal class MyWindow : Window
{
    public MyWindow()
        : base("Hello World")
    {
        CreateButton("Open Modal", 10, 10, 200, 24, 1);
    }

    protected override LRESULT? WindowProc(HWND hwnd, uint msg, WPARAM wParam, LPARAM lParam)
    {
        if (msg == MessageDecoder.WM_COMMAND)
        {
            var id = wParam.Value.LOWORD();
            switch (id)
            {
                case 1:
                    var dlg = new DialogWindow(Handle);
                    var cr = ClientRect;
                    dlg.ResizeClient(cr.Width - 30, cr.Height - 30);
                    dlg.Center(Handle);
                    dlg.ShowModal(this);
                    break;

                default:
                    return 0; // handled
            }
        }

        return base.WindowProc(hwnd, msg, wParam, lParam);
    }
}

internal class DialogWindow : Window
{
    private static int _level;

    public DialogWindow(HWND parentHandle)
        : base($"Dialog Box #{_level++}", parentHandle: parentHandle)
    {
        CreateButton("Open Modal", 10, 10, 200, 24, 1);
    }

    protected override LRESULT? WindowProc(HWND hwnd, uint msg, WPARAM wParam, LPARAM lParam)
    {
        if (msg == MessageDecoder.WM_KEYDOWN && wParam.Value == (nuint)VIRTUAL_KEY.VK_ESCAPE)
        {
            Close();
            return 0; // handled
        }

        if (msg == MessageDecoder.WM_COMMAND)
        {
            var id = wParam.Value.LOWORD();
            switch (id)
            {
                case 1:
                    var dlg = new DialogWindow(Handle);
                    var cr = ClientRect;
                    dlg.ResizeClient(cr.Width - 30, cr.Height - 30);
                    dlg.Center(Handle);
                    dlg.ShowModal(this);
                    break;

                default:
                    return 0; // handled
            }
        }

        return base.WindowProc(hwnd, msg, wParam, lParam);
    }
}