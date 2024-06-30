#nullable enable
namespace DirectN;

public partial struct DDRAWI_DDRAWPALETTE_GBL
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nuint dwReserved1;
        
        [FieldOffset(0)]
        public HPALETTE hHELGDIPalette;
    }
    
    public uint dwRefCnt;
    public uint dwFlags;
    public nint lpDD_lcl;
    public uint dwProcessId;
    public nint lpColorTable;
    public _Anonymous_e__Union Anonymous;
    public uint dwDriverReserved;
    public uint dwContentsStamp;
    public uint dwSaveStamp;
    public uint dwHandle;
}
