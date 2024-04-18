namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidlbase/nn-objidlbase-ienumunknown
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000100-0000-0000-c000-000000000046")]
public partial interface IEnumUnknown
{
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumunknown-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Next(uint celt, out nint rgelt, nint/* nint */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumunknown-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumunknown-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-ienumunknown-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Clone(out IEnumUnknown ppenum);
}
