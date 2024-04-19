namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-itoccollection
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("23fee831-ae96-42df-b170-25a04847a3ca")]
public partial interface ITocCollection
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoccollection-getentrycount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEntryCount(ref uint pdwEntryCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoccollection-getentrybyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEntryByIndex(uint dwEntryIndex, out IToc ppToc);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoccollection-addentry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEntry(IToc pToc, ref uint pdwEntryIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoccollection-addentrybyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEntryByIndex(uint dwEntryIndex, IToc pToc);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itoccollection-removeentrybyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveEntryByIndex(uint dwEntryIndex);
}
