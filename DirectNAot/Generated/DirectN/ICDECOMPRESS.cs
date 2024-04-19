namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-icdecompress
[StructLayout(LayoutKind.Sequential)]
public partial struct ICDECOMPRESS
{
    public uint dwFlags;
    public nint lpbiInput;
    public nint lpInput;
    public nint lpbiOutput;
    public nint lpOutput;
    public uint ckid;
}
