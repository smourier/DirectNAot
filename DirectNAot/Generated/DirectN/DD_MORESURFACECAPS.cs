#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_moresurfacecaps
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_MORESURFACECAPS
{
    [InlineArray(1)]
    public partial struct InlineArrayNTExtendedHeapRestrictions1
    {
        public NTExtendedHeapRestrictions Data;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct NTExtendedHeapRestrictions
    {
        public DDSCAPSEX ddsCapsEx;
        public DDSCAPSEX ddsCapsExAlt;
    }
    
    public uint dwSize;
    public DDSCAPSEX ddsCapsMore;
    public InlineArrayNTExtendedHeapRestrictions1 ddsExtendedHeapRestrictions; // variable-length array placeholder
}
