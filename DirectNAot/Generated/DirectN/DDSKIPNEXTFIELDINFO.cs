namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddskipnextfieldinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDSKIPNEXTFIELDINFO
{
    public nint lpVideoPortData;
    public uint dwSkipFlags;
}
