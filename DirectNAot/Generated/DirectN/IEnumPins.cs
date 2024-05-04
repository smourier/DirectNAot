﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ienumpins
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a86892-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IEnumPins
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumpins-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cPins, [MarshalUsing(CountElementName = nameof(cPins))] out IPin[] ppPins, nint /* optional uint* */ pcFetched);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumpins-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cPins);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumpins-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienumpins-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IEnumPins ppEnum);
}
