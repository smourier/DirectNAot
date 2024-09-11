#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsompagereference
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ed360180-6f92-4998-890d-2f208531a0a0")]
public partial interface IXpsOMPageReference
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-getowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOwner([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDocument>))] out IXpsOMDocument document);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-getpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPage>))] out IXpsOMPage page);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-setpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPage>))] IXpsOMPage page);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-discardpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DiscardPage();
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-ispageloaded
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsPageLoaded(out BOOL isPageLoaded);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-getadvisorypagedimensions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAdvisoryPageDimensions(out XPS_SIZE pageDimensions);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-setadvisorypagedimensions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAdvisoryPageDimensions(in XPS_SIZE pageDimensions);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-getstoryfragmentsresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStoryFragmentsResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMStoryFragmentsResource>))] out IXpsOMStoryFragmentsResource storyFragmentsResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-setstoryfragmentsresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStoryFragmentsResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMStoryFragmentsResource>))] IXpsOMStoryFragmentsResource storyFragmentsResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-getprintticketresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrintTicketResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPrintTicketResource>))] out IXpsOMPrintTicketResource printTicketResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-setprintticketresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrintTicketResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPrintTicketResource>))] IXpsOMPrintTicketResource printTicketResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-getthumbnailresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetThumbnailResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageResource>))] out IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-setthumbnailresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetThumbnailResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageResource>))] IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-collectlinktargets
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CollectLinkTargets([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMNameCollection>))] out IXpsOMNameCollection linkTargets);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-collectpartresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CollectPartResources([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPartResources>))] out IXpsOMPartResources partResources);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-hasrestrictedfonts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasRestrictedFonts(out BOOL restrictedFonts);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompagereference-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPageReference>))] out IXpsOMPageReference pageReference);
}
