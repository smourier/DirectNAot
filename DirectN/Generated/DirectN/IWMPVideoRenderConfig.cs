#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmprealestate/nn-wmprealestate-iwmpvideorenderconfig
[GeneratedComInterface, Guid("6d6cf803-1ec0-4c8d-b3ca-f18e27282074")]
public partial interface IWMPVideoRenderConfig
{
    // https://learn.microsoft.com/windows/win32/api/wmprealestate/nf-wmprealestate-iwmpvideorenderconfig-put_presenteractivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_presenterActivate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] IMFActivate pActivate);
}
