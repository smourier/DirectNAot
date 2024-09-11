#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfremotedesktopplugin
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("1cde6309-cae0-4940-907e-c1ec9c3d1d4a")]
public partial interface IMFRemoteDesktopPlugin
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfremotedesktopplugin-updatetopology
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateTopology([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTopology>))] IMFTopology pTopology);
}
