﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfschemehandler
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("6d4c7b74-52a0-4bb7-b0db-55f29f47a668")]
public partial interface IMFSchemeHandler
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfschemehandler-begincreateobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginCreateObject(PWSTR pwszURL, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pProps, nint /* optional nint* */ ppIUnknownCancelCookie, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfschemehandler-endcreateobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndCreateObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult, out MF_OBJECT_TYPE pObjectType, out nint ppObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfschemehandler-cancelobjectcreation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelObjectCreation(nint pIUnknownCancelCookie);
}
