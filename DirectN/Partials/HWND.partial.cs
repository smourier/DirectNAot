namespace DirectN;

public partial struct HWND
{
    public static readonly HWND BOTTOM = new() { Value = 1 };
    public static readonly HWND NOTOPMOST = new() { Value = -2 };
    public static readonly HWND TOP = new();
    public static readonly HWND TOPMOST = new() { Value = -1 };
}
