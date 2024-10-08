﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("4c963678-3a51-4b88-8531-98b90b6508f2")]
public partial interface IXFeedFolder
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Feeds([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXFeedsEnum>))] out IXFeedsEnum ppfe);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Subfolders([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXFeedsEnum>))] out IXFeedsEnum ppfe);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFeed(PWSTR pszName, PWSTR pszUrl, in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSubfolder(PWSTR pszName, in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExistsFeed(PWSTR pszName, in BOOL pbFeedExists);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExistsSubfolder(PWSTR pszName, in BOOL pbSubfolderExists);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFeed(PWSTR pszName, in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubfolder(PWSTR pszName, in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Name(out PWSTR ppszName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Rename(PWSTR pszName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Path(out PWSTR ppszPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Move(PWSTR pszPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Parent(in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsRoot(out BOOL pbIsRootFeedFolder);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWatcher(FEEDS_EVENTS_SCOPE scope, FEEDS_EVENTS_MASK mask, in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TotalUnreadItemCount(out uint puiTotalUnreadItemCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TotalItemCount(out uint puiTotalItemCount);
}
