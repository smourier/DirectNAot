#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-iccompress
public partial struct ICCOMPRESS
{
    public uint dwFlags;
    public nint lpbiOutput;
    public nint lpOutput;
    public nint lpbiInput;
    public nint lpInput;
    public nint lpckid;
    public nint lpdwFlags;
    public int lFrameNum;
    public uint dwFrameSize;
    public uint dwQuality;
    public nint lpbiPrev;
    public nint lpPrev;
}
