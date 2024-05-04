#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-itocentrylist
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("3a8cccbd-0efd-43a3-b838-f38a552ba237")]
public partial interface ITocEntryList
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocentrylist-getentrycount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEntryCount(ref uint pdwEntryCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocentrylist-getentrybyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEntryByIndex(uint dwEntryIndex, out ITocEntry ppEntry);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocentrylist-addentry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEntry(ITocEntry pEntry, ref uint pdwEntryIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocentrylist-addentrybyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEntryByIndex(uint dwEntryIndex, ITocEntry pEntry);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocentrylist-removeentrybyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveEntryByIndex(uint dwEntryIndex);
}
