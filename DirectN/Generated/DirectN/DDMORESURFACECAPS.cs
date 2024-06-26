﻿#nullable enable
namespace DirectN;

public partial struct DDMORESURFACECAPS
{
    [InlineArray(InlineArrayExtendedHeapRestrictions_1.Length)]
    public partial struct InlineArrayExtendedHeapRestrictions_1
    {
        public const int Length = 1;
        
        public ExtendedHeapRestrictions Data;
    }
    
    public struct ExtendedHeapRestrictions
    {
        public DDSCAPSEX ddsCapsEx;
        public DDSCAPSEX ddsCapsExAlt;
    }
    
    public uint dwSize;
    public DDSCAPSEX ddsCapsMore;
    public InlineArrayExtendedHeapRestrictions_1 ddsExtendedHeapRestrictions; // variable-length array placeholder
}
