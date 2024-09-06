#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imftopoloader
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("de9a6157-f660-4643-b56a-df9f7998c7cd")]
public partial interface IMFTopoLoader
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopoloader-load
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load(IMFTopology pInputTopo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTopology>))] out IMFTopology ppOutputTopo, IMFTopology pCurrentTopo);
}
