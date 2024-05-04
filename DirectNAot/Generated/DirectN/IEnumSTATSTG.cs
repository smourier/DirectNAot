#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-ienumstatstg
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000000d-0000-0000-c000-000000000046")]
public partial interface IEnumSTATSTG
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienumstatstg-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [MarshalUsing(CountElementName = nameof(celt))] out STATSTG[] rgelt, nint /* optional uint* */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienumstatstg-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienumstatstg-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienumstatstg-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IEnumSTATSTG ppenum);
}
