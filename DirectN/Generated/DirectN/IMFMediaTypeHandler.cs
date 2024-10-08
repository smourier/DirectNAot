﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfmediatypehandler
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("e93dcf6c-4b07-4e1e-8123-aa16ed6eadf5")]
public partial interface IMFMediaTypeHandler
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediatypehandler-ismediatypesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsMediaTypeSupported([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMediaType, nint /* optional IMFMediaType* */ ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediatypehandler-getmediatypecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaTypeCount(out uint pdwTypeCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediatypehandler-getmediatypebyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaTypeByIndex(uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediatypehandler-setcurrentmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediatypehandler-getcurrentmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediatypehandler-getmajortype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMajorType(out Guid pguidMajorType);
}
