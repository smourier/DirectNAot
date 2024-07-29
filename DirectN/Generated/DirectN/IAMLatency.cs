#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamlatency
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("62ea93ba-ec62-11d2-b770-00c04fb6bd3d")]
public partial interface IAMLatency
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamlatency-getlatency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLatency(out long prtLatency);
}
