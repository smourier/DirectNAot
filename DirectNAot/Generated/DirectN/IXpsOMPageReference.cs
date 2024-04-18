namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsompagereference
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ed360180-6f92-4998-890d-2f208531a0a0")]
public partial interface IXpsOMPageReference
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-getowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOwner(out IXpsOMDocument document);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-getpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPage(out IXpsOMPage page);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-setpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPage(IXpsOMPage page);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-discardpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DiscardPage();
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-ispageloaded
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT IsPageLoaded([MarshalAs(UnmanagedType.U4)] out bool isPageLoaded);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-getadvisorypagedimensions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAdvisoryPageDimensions(out XPS_SIZE pageDimensions);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-setadvisorypagedimensions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAdvisoryPageDimensions(in XPS_SIZE pageDimensions);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-getstoryfragmentsresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetStoryFragmentsResource(out IXpsOMStoryFragmentsResource storyFragmentsResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-setstoryfragmentsresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetStoryFragmentsResource(IXpsOMStoryFragmentsResource storyFragmentsResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-getprintticketresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPrintTicketResource(out IXpsOMPrintTicketResource printTicketResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-setprintticketresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPrintTicketResource(IXpsOMPrintTicketResource printTicketResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-getthumbnailresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetThumbnailResource(out IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-setthumbnailresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetThumbnailResource(IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-collectlinktargets
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CollectLinkTargets(out IXpsOMNameCollection linkTargets);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-collectpartresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CollectPartResources(out IXpsOMPartResources partResources);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-hasrestrictedfonts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT HasRestrictedFonts([MarshalAs(UnmanagedType.U4)] out bool restrictedFonts);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Clone(out IXpsOMPageReference pageReference);
}
