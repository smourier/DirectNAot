#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mediaobj/nn-mediaobj-imediabuffer
[GeneratedComInterface, Guid("59eff8b9-938c-4a26-82f2-95cb84cdc837")]
public partial interface IMediaBuffer
{
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediabuffer-setlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLength(uint cbLength);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediabuffer-getmaxlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxLength(out uint pcbMaxLength);
    
    // https://learn.microsoft.com/windows/win32/api/mediaobj/nf-mediaobj-imediabuffer-getbufferandlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferAndLength(nint /* optional byte** */ ppBuffer, nint /* optional uint* */ pcbLength);
}
