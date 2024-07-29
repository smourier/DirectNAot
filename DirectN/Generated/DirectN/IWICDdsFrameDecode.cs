#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicddsframedecode
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("3d4c0c61-18a4-41e4-bd80-481a4fc9f464")]
public partial interface IWICDdsFrameDecode
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicddsframedecode-getsizeinblocks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSizeInBlocks(out uint pWidthInBlocks, out uint pHeightInBlocks);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicddsframedecode-getformatinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormatInfo(out WICDdsFormatInfo pFormatInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicddsframedecode-copyblocks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyBlocks(in WICRect prcBoundsInBlocks, uint cbStride, uint cbBufferSize, nint /* byte array */ pbBuffer);
}
