﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/nn-photoacquire-iphotoacquireprogresscb
[GeneratedComInterface, Guid("00f2ce1e-935e-4248-892c-130f32c45cb4")]
public partial interface IPhotoAcquireProgressCB
{
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-cancelled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancelled(out BOOL pfCancelled);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-startenumeration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartEnumeration([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireSource?>))] IPhotoAcquireSource? pPhotoAcquireSource);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-founditem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FoundItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireItem?>))] IPhotoAcquireItem? pPhotoAcquireItem);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-endenumeration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndEnumeration(HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-starttransfer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartTransfer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireSource?>))] IPhotoAcquireSource? pPhotoAcquireSource);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-startitemtransfer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartItemTransfer(uint nItemIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireItem?>))] IPhotoAcquireItem? pPhotoAcquireItem);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-directorycreated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DirectoryCreated(PWSTR pszDirectory);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-updatetransferpercent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateTransferPercent(BOOL fOverall, uint nPercent);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-enditemtransfer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndItemTransfer(uint nItemIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireItem?>))] IPhotoAcquireItem? pPhotoAcquireItem, HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-endtransfer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndTransfer(HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-startdelete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartDelete([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireSource?>))] IPhotoAcquireSource? pPhotoAcquireSource);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-startitemdelete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartItemDelete(uint nItemIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireItem?>))] IPhotoAcquireItem? pPhotoAcquireItem);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-updatedeletepercent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateDeletePercent(uint nPercent);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-enditemdelete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndItemDelete(uint nItemIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireItem?>))] IPhotoAcquireItem? pPhotoAcquireItem, HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-enddelete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndDelete(HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-endsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndSession(HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-getdeleteafteracquire
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeleteAfterAcquire(out BOOL pfDeleteAfterAcquire);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-erroradvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ErrorAdvise(HRESULT hr, PWSTR pszErrorMessage, ERROR_ADVISE_MESSAGE_TYPE nMessageType, out ERROR_ADVISE_RESULT pnErrorAdviseResult);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireprogresscb-getuserinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserInput(in Guid riidType, nint pUnknown, out PROPVARIANT pPropVarResult, nint /* optional PROPVARIANT* */ pPropVarDefault);
}
