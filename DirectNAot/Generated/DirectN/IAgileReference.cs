#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-iagilereference
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("c03f6a43-65a4-9818-987e-e0b810d2a6f2")]
public partial interface IAgileReference
{
    // https://learn.microsoft.com/windows/win32/WinRT/iagilereference-resolve
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resolve(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvObjectReference);
}
