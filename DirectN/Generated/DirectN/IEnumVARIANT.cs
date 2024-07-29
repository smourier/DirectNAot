#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-ienumvariant
[GeneratedComInterface, Guid("00020404-0000-0000-c000-000000000046")]
public partial interface IEnumVARIANT
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-ienumvariant-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] VARIANT[] rgVar, out uint pCeltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-ienumvariant-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-ienumvariant-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-ienumvariant-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumVARIANT>))] out IEnumVARIANT ppEnum);
}
