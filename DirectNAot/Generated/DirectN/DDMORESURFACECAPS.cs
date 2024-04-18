namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDMORESURFACECAPS
{
    [InlineArray(1)]
    public partial struct InlineArrayExtendedHeapRestrictions1
    {
        public ExtendedHeapRestrictions Data;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct ExtendedHeapRestrictions
    {
        public DDSCAPSEX ddsCapsEx;
        public DDSCAPSEX ddsCapsExAlt;
    }
    
    public uint dwSize;
    public DDSCAPSEX ddsCapsMore;
    public InlineArrayExtendedHeapRestrictions1 ddsExtendedHeapRestrictions; // variable-length array placeholder
}
