#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-itocentry
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f22f5e06-585c-4def-8523-6555cfbc0cb3")]
public partial interface ITocEntry
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocentry-settitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTitle(PWSTR pwszTitle);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocentry-gettitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTitle(ref ushort pwTitleSize, [MarshalUsing(CountElementName = nameof(pwTitleSize))] out PWSTR pwszTitle);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocentry-setdescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDescriptor(ref TOC_ENTRY_DESCRIPTOR pDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocentry-getdescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescriptor(ref TOC_ENTRY_DESCRIPTOR pDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocentry-setsubentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSubEntries(uint dwNumSubEntries, ref ushort pwSubEntryIndices);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocentry-getsubentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubEntries(ref uint pdwNumSubEntries, ref ushort pwSubEntryIndices);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocentry-setdescriptiondata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDescriptionData(uint dwDescriptionDataSize, nint /* byte array */ pbtDescriptionData, ref Guid pguidType);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocentry-getdescriptiondata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescriptionData(ref uint pdwDescriptionDataSize, nint /* byte array */ pbtDescriptionData, ref Guid pGuidType);
}
