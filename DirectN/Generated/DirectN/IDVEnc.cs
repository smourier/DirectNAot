#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-idvenc
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("d18e17a0-aacb-11d0-afb0-00aa00b67a42")]
public partial interface IDVEnc
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvenc-get_iformatresolution
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IFormatResolution(out int VideoFormat, out int DVFormat, out int Resolution, byte fDVInfo, out DVINFO sDVInfo);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvenc-put_iformatresolution
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IFormatResolution(int VideoFormat, int DVFormat, int Resolution, byte fDVInfo, in DVINFO sDVInfo);
}
