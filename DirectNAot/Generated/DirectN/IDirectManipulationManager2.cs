namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationmanager2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("fa1005e9-3d16-484c-bfc9-62b61e56ec4e")]
public partial interface IDirectManipulationManager2 : IDirectManipulationManager
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationmanager2-createbehavior
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBehavior(in Guid clsid, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ @object);
}
