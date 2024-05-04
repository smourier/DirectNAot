#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationmanager3
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("2cb6b33d-ffe8-488c-b750-fbdfe88dca8c")]
public partial interface IDirectManipulationManager3 : IDirectManipulationManager2
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationmanager3-getservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetService(in Guid clsid, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ @object);
}
