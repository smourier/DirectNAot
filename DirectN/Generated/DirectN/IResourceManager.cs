﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iresourcemanager
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868ac-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IResourceManager
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iresourcemanager-register
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Register(PWSTR pName, int cResource, out int plToken);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iresourcemanager-registergroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterGroup(PWSTR pName, int cResource, [In][MarshalUsing(CountElementName = nameof(cResource))] int[] palTokens, out int plToken);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iresourcemanager-requestresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RequestResource(int idResource, nint pFocusObject, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IResourceConsumer>))] IResourceConsumer pConsumer);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iresourcemanager-notifyacquire
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyAcquire(int idResource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IResourceConsumer>))] IResourceConsumer pConsumer, HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iresourcemanager-notifyrelease
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyRelease(int idResource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IResourceConsumer>))] IResourceConsumer pConsumer, BOOL bStillWant);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iresourcemanager-cancelrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelRequest(int idResource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IResourceConsumer>))] IResourceConsumer pConsumer);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iresourcemanager-setfocus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFocus(nint pFocusObject);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iresourcemanager-releasefocus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseFocus(nint pFocusObject);
}
