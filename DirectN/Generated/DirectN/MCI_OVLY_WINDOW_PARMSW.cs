#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_OVLY_WINDOW_PARMSW
{
    public nuint dwCallback;
    public HWND hWnd;
    public uint nCmdShow;
    public PWSTR lpstrText;
}
