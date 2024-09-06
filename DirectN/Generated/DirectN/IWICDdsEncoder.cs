#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicddsencoder
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("5cacdb4c-407e-41b3-b936-d0f010cd6732")]
public partial interface IWICDdsEncoder
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicddsencoder-setparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetParameters(in WICDdsParameters pParameters);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicddsencoder-getparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParameters(out WICDdsParameters pParameters);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicddsencoder-createnewframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateNewFrame([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapFrameEncode>))] out IWICBitmapFrameEncode ppIFrameEncode, out uint pArrayIndex, out uint pMipLevel, out uint pSliceIndex);
}
