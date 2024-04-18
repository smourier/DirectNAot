﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/nn-dxcore_interface-idxcoreadapterfactory
[GeneratedComInterface, Guid("78ee5945-c36e-4b13-a669-005dd11c0f06")]
public partial interface IDXCoreAdapterFactory
{
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterfactory-createadapterlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateAdapterList(uint numAttributes, in Guid filterAttributes, in Guid riid, out nint ppvAdapterList);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterfactory-getadapterbyluid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAdapterByLuid(in LUID adapterLUID, in Guid riid, out nint ppvAdapter);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterfactory-isnotificationtypesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsNotificationTypeSupported(DXCoreNotificationType notificationType);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterfactory-registereventnotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RegisterEventNotification(nint dxCoreObject, DXCoreNotificationType notificationType, PFN_DXCORE_NOTIFICATION_CALLBACK callbackFunction, nint/* nint */ callbackContext, out uint eventCookie);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterfactory-unregistereventnotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UnregisterEventNotification(uint eventCookie);
}
