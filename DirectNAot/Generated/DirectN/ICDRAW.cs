#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-icdraw
[StructLayout(LayoutKind.Sequential)]
public partial struct ICDRAW
{
    public uint dwFlags;
    public nint lpFormat;
    public nint lpData;
    public uint cbData;
    public int lTime;
}
