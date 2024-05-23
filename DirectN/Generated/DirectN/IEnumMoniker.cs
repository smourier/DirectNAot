#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-ienummoniker
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000102-0000-0000-c000-000000000046")]
public partial interface IEnumMoniker
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienummoniker-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] IMoniker[] rgelt, nint /* optional uint* */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienummoniker-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienummoniker-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienummoniker-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumMoniker>))] out IEnumMoniker ppenum);
}
