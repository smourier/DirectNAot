#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfmuxstreamattributesmanager
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("ce8bd576-e440-43b3-be34-1e53f565f7e8")]
public partial interface IMFMuxStreamAttributesManager
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmuxstreamattributesmanager-getstreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamCount(out uint pdwMuxStreamCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmuxstreamattributesmanager-getattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributes(uint dwMuxStreamIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppStreamAttributes);
}
