#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-iwmcodecleakybucket
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("a81ba647-6227-43b7-b231-c7b15135dd7d")]
public partial interface IWMCodecLeakyBucket
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmcodecleakybucket-setbuffersizebits
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBufferSizeBits(uint ulBufferSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmcodecleakybucket-getbuffersizebits
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferSizeBits(ref uint pulBufferSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmcodecleakybucket-setbufferfullnessbits
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBufferFullnessBits(uint ulBufferFullness);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmcodecleakybucket-getbufferfullnessbits
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferFullnessBits(ref uint pulBufferFullness);
}
