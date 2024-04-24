﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ienumcomponenttypes
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("8a674b4a-1f63-11d3-b64c-00c04f79498e")]
public partial interface IEnumComponentTypes
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ienumcomponenttypes-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [MarshalUsing(CountElementName = nameof(celt))] out IComponentType[] rgelt, out uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ienumcomponenttypes-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ienumcomponenttypes-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ienumcomponenttypes-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IEnumComponentTypes ppEnum);
}
