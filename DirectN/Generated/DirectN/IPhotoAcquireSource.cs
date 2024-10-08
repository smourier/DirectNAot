﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/nn-photoacquire-iphotoacquiresource
[GeneratedComInterface, Guid("00f2c703-8613-4282-a53b-6ec59c5883ac")]
public partial interface IPhotoAcquireSource
{
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresource-getfriendlyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFriendlyName(out BSTR pbstrFriendlyName);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresource-getdeviceicons
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceIcons(uint nSize, nint /* optional HICON* */ phLargeIcon, nint /* optional HICON* */ phSmallIcon);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresource-initializeitemlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeItemList(BOOL fForceEnumeration, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireProgressCB?>))] IPhotoAcquireProgressCB? pPhotoAcquireProgressCB, nint /* optional uint* */ pnItemCount);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresource-getitemcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemCount(out uint pnItemCount);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresource-getitemat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemAt(uint nIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireItem>))] out IPhotoAcquireItem ppPhotoAcquireItem);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresource-getphotoacquiresettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPhotoAcquireSettings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireSettings>))] out IPhotoAcquireSettings ppPhotoAcquireSettings);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiresource-getdeviceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceId(out BSTR pbstrDeviceId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindToObject(in Guid riid, out nint ppv);
}
