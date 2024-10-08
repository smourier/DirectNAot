﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/nn-photoacquire-iphotoacquire
[GeneratedComInterface, Guid("00f23353-e31b-4955-a8ad-ca5ebf31e2ce")]
public partial interface IPhotoAcquire
{
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquire-createphotosource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePhotoSource(PWSTR pszDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireSource>))] out IPhotoAcquireSource ppPhotoAcquireSource);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquire-acquire
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Acquire([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireSource?>))] IPhotoAcquireSource? pPhotoAcquireSource, BOOL fShowProgress, HWND hWndParent, PWSTR pszApplicationName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireProgressCB?>))] IPhotoAcquireProgressCB? pPhotoAcquireProgressCB);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquire-enumresults
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumResults([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumString>))] out IEnumString ppEnumFilePaths);
}
