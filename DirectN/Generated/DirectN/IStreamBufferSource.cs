#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-istreambuffersource
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("1c5bd776-6ced-4f44-8164-5eab0e98db12")]
public partial interface IStreamBufferSource
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambuffersource-setstreamsink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamSink(IStreamBufferSink pIStreamBufferSink);
}
