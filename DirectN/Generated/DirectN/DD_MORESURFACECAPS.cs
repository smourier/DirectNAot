#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_moresurfacecaps
public partial struct DD_MORESURFACECAPS
{
    [InlineArray(InlineArrayNTExtendedHeapRestrictions_1.Length)]
    public partial struct InlineArrayNTExtendedHeapRestrictions_1
    {
        public const int Length = 1;
        
        public NTExtendedHeapRestrictions Data;
    }
    
    public struct NTExtendedHeapRestrictions
    {
        public DDSCAPSEX ddsCapsEx;
        public DDSCAPSEX ddsCapsExAlt;
    }
    
    public uint dwSize;
    public DDSCAPSEX ddsCapsMore;
    public InlineArrayNTExtendedHeapRestrictions_1 ddsExtendedHeapRestrictions; // variable-length array placeholder
}
