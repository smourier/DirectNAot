#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidlbase/nn-objidlbase-ienumstring
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000101-0000-0000-c000-000000000046")]
public partial interface IEnumString
{
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumstring-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] PWSTR[] rgelt, nint /* optional uint* */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumstring-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumstring-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumstring-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IEnumString ppenum);
}
