#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ifilesinkfilter2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00855b90-ce1b-11d0-bd4f-00a0c911ce86")]
public partial interface IFileSinkFilter2 : IFileSinkFilter
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifilesinkfilter2-setmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMode(uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifilesinkfilter2-getmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMode(out uint pdwFlags);
}
