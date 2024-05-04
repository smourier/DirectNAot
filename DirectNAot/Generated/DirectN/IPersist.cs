#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-ipersist
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000010c-0000-0000-c000-000000000046")]
public partial interface IPersist
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersist-getclassid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClassID(out Guid pClassID);
}
