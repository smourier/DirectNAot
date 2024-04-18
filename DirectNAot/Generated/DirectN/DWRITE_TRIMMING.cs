namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_trimming
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_TRIMMING
{
    public DWRITE_TRIMMING_GRANULARITY granularity;
    public uint delimiter;
    public uint delimiterCount;
}
