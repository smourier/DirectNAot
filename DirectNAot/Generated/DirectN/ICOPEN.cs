#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-icopen
[StructLayout(LayoutKind.Sequential)]
public partial struct ICOPEN
{
    public uint dwSize;
    public uint fccType;
    public uint fccHandler;
    public uint dwVersion;
    public uint dwFlags;
    public LRESULT dwError;
    public nint pV1Reserved;
    public nint pV2Reserved;
    public uint dnDevNode;
}
