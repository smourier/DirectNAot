namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectShow/ksmultiple-item
[StructLayout(LayoutKind.Sequential)]
public partial struct KSMULTIPLE_ITEM
{
    public uint Size;
    public uint Count;
}
