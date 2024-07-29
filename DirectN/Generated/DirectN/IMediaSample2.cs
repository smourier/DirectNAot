#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-imediasample2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("36b73884-c2c8-11cf-8b46-00805f6cef60")]
public partial interface IMediaSample2 : IMediaSample
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample2-getproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperties(uint cbProperties, nint /* byte array */ pbProperties);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample2-setproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperties(uint cbProperties, nint /* byte array */ pbProperties);
}
