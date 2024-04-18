namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-ienumstatstg
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000000d-0000-0000-c000-000000000046")]
public partial interface IEnumSTATSTG
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienumstatstg-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Next(uint celt, out STATSTG rgelt, nint/* nint */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienumstatstg-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienumstatstg-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ienumstatstg-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Clone(out IEnumSTATSTG ppenum);
}
