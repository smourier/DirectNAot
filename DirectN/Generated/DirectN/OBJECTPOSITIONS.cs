#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-objectpositions
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct OBJECTPOSITIONS
{
    public NMHDR nmhdr;
    public int cObjectCount;
    public nint pcpPositions;
}
