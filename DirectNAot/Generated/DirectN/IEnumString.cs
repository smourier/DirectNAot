namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidlbase/nn-objidlbase-ienumstring
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000101-0000-0000-c000-000000000046")]
public partial interface IEnumString
{
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumstring-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Next(uint celt, out PWSTR rgelt, nint /* uint */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumstring-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumstring-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumstring-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Clone(out IEnumString ppenum);
}
