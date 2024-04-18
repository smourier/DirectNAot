namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomcoreproperties
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("3340fe8f-4027-4aa1-8f5f-d35ae45fe597")]
public partial interface IXpsOMCoreProperties : IXpsOMPart
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOwner(out IXpsOMPackage package);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getcategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCategory(out PWSTR category);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setcategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCategory(PWSTR category);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getcontentstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetContentStatus(out PWSTR contentStatus);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setcontentstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetContentStatus(PWSTR contentStatus);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getcontenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetContentType(out PWSTR contentType);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setcontenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetContentType(PWSTR contentType);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getcreated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCreated(out SYSTEMTIME created);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setcreated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCreated(in SYSTEMTIME created);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getcreator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCreator(out PWSTR creator);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setcreator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCreator(PWSTR creator);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDescription(out PWSTR description);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetDescription(PWSTR description);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getidentifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetIdentifier(out PWSTR identifier);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setidentifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetIdentifier(PWSTR identifier);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getkeywords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetKeywords(out PWSTR keywords);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setkeywords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetKeywords(PWSTR keywords);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetLanguage(out PWSTR language);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetLanguage(PWSTR language);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getlastmodifiedby
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetLastModifiedBy(out PWSTR lastModifiedBy);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setlastmodifiedby
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetLastModifiedBy(PWSTR lastModifiedBy);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getlastprinted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetLastPrinted(out SYSTEMTIME lastPrinted);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setlastprinted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetLastPrinted(in SYSTEMTIME lastPrinted);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getmodified
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetModified(out SYSTEMTIME modified);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setmodified
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetModified(in SYSTEMTIME modified);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getrevision
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRevision(out PWSTR revision);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setrevision
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRevision(PWSTR revision);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getsubject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSubject(out PWSTR subject);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setsubject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSubject(PWSTR subject);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-gettitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetTitle(out PWSTR title);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-settitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTitle(PWSTR title);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-getversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVersion(out PWSTR version);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-setversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetVersion(PWSTR version);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcoreproperties-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Clone(out IXpsOMCoreProperties coreProperties);
}
