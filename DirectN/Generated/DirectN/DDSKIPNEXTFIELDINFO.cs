#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddskipnextfieldinfo
public partial struct DDSKIPNEXTFIELDINFO
{
    public nint lpVideoPortData;
    public uint dwSkipFlags;
}
