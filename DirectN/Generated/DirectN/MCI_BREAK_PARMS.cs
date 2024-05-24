#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-break-parms
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_BREAK_PARMS
{
    public nuint dwCallback;
    public int nVirtKey;
    public HWND hwndBreak;
}
