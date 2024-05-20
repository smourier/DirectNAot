#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imf2dbuffer
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7dc9d5f9-9ed9-44ec-9bbf-0600bb589fbb")]
public partial interface IMF2DBuffer
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imf2dbuffer-lock2d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Lock2D(out nint /* byte array */ ppbScanline0, out int plPitch);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imf2dbuffer-unlock2d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unlock2D();
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imf2dbuffer-getscanline0andpitch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScanline0AndPitch(out nint /* byte array */ pbScanline0, out int plPitch);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imf2dbuffer-iscontiguousformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsContiguousFormat([MarshalAs(UnmanagedType.U4)] out bool pfIsContiguous);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imf2dbuffer-getcontiguouslength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContiguousLength(out uint pcbLength);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imf2dbuffer-contiguouscopyto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ContiguousCopyTo(nint /* byte array */ pbDestBuffer, uint cbDestBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imf2dbuffer-contiguouscopyfrom
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ContiguousCopyFrom(nint /* byte array */ pbSrcBuffer, uint cbSrcBuffer);
}
