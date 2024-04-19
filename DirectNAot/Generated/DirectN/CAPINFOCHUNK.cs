namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-capinfochunk
[StructLayout(LayoutKind.Sequential)]
public partial struct CAPINFOCHUNK
{
    public uint fccInfoID;
    public nint lpData;
    public int cbData;
}
