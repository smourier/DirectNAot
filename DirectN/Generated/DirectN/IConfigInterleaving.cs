#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iconfiginterleaving
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("bee3d220-157b-11d0-bd23-00a0c911ce86")]
public partial interface IConfigInterleaving
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iconfiginterleaving-put_mode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Mode(InterleavingMode mode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iconfiginterleaving-get_mode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Mode(out InterleavingMode pMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iconfiginterleaving-put_interleaving
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Interleaving(in long prtInterleave, in long prtPreroll);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iconfiginterleaving-get_interleaving
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Interleaving(out long prtInterleave, out long prtPreroll);
}
