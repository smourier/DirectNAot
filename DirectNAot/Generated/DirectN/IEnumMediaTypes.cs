#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ienummediatypes
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("89c31040-846b-11ce-97d3-00aa0055595a")]
public partial interface IEnumMediaTypes
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienummediatypes-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cMediaTypes, [MarshalUsing(CountElementName = nameof(cMediaTypes))] ref AM_MEDIA_TYPE[] ppMediaTypes, nint /* optional uint* */ pcFetched);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienummediatypes-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cMediaTypes);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienummediatypes-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ienummediatypes-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IEnumMediaTypes ppEnum);
}
