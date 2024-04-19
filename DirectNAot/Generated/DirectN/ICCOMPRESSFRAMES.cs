namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-iccompressframes
[StructLayout(LayoutKind.Sequential)]
public partial struct ICCOMPRESSFRAMES
{
    public uint dwFlags;
    public nint lpbiOutput;
    public LPARAM lOutput;
    public nint lpbiInput;
    public LPARAM lInput;
    public int lStartFrame;
    public int lFrameCount;
    public int lQuality;
    public int lDataRate;
    public int lKeyRate;
    public uint dwRate;
    public uint dwScale;
    public uint dwOverheadPerFrame;
    public uint dwReserved2;
    public nint GetData;
    public nint PutData;
}
