#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/encdec/nn-encdec-ixdscodecconfig
[GeneratedComInterface, Guid("c4c4c4d3-0049-4e2b-98fb-9537f6ce516d")]
public partial interface IXDSCodecConfig
{
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ixdscodecconfig-getsecurechannelobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSecureChannelObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppUnkDRMSecureChannel);
    
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-ixdscodecconfig-setpausebuffertime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPauseBufferTime(uint dwPauseBufferTime);
}
