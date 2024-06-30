#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-icsetstatusproc
public partial struct ICSETSTATUSPROC
{
    public uint dwFlags;
    public LPARAM lParam;
    public nint Status;
}
