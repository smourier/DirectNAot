#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_OVLY_WINDOW_PARMSA
{
    public nuint dwCallback;
    public HWND hWnd;
    public uint nCmdShow;
    public PSTR lpstrText;
}
