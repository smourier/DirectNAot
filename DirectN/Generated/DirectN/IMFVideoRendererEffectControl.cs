#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("604d33d7-cf23-41d5-8224-5bbbb1a87475")]
public partial interface IMFVideoRendererEffectControl
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnAppServiceConnectionEstablished(nint pAppServiceConnection);
}
