#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidlbase/nn-objidlbase-ienumunknown
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000100-0000-0000-c000-000000000046")]
public partial interface IEnumUnknown
{
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumunknown-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] nint[] rgelt, nint /* optional uint* */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumunknown-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumunknown-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumunknown-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumUnknown>))] out IEnumUnknown ppenum);
}
