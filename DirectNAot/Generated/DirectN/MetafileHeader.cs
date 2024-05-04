#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MetafileHeader
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public METAHEADER WmfHeader;
        
        [FieldOffset(0)]
        public ENHMETAHEADER3 EmfHeader;
    }
    
    public MetafileType Type;
    public uint Size;
    public uint Version;
    public uint EmfPlusFlags;
    public float DpiX;
    public float DpiY;
    public int X;
    public int Y;
    public int Width;
    public int Height;
    public _Anonymous_e__Union Anonymous;
    public int EmfPlusHeaderSize;
    public int LogicalDpiX;
    public int LogicalDpiY;
}
