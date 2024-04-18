﻿namespace DirectN;

[GeneratedComInterface, Guid("df0c7cec-cdeb-4d4a-b91c-721bf22f4e6c")]
public partial interface IDCompositionInkTrailDevice
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDelegatedInkTrail(out IDCompositionDelegatedInkTrail inkTrail);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDelegatedInkTrailForSwapChain(nint swapChain, out IDCompositionDelegatedInkTrail inkTrail);
}
