#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-ienumformatetc
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000103-0000-0000-c000-000000000046")]
public partial interface IEnumFORMATETC
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienumformatetc-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] FORMATETC[] rgelt, nint /* optional uint* */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienumformatetc-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienumformatetc-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienumformatetc-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumFORMATETC>))] out IEnumFORMATETC ppenum);
}
