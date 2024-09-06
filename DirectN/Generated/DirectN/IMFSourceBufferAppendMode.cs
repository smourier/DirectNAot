#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("19666fb4-babe-4c55-bc03-0a074da37e2a")]
public partial interface IMFSourceBufferAppendMode
{
    [PreserveSig]
    MF_MSE_APPEND_MODE GetAppendMode();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAppendMode(MF_MSE_APPEND_MODE mode);
}
