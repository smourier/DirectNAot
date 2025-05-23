﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfmediasource
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("279a808d-aec7-40c8-9c6b-a6b492c78a66")]
public partial interface IMFMediaSource : IMFMediaEventGenerator
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasource-getcharacteristics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCharacteristics(out uint pdwCharacteristics);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasource-createpresentationdescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePresentationDescriptor([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationDescriptor>))] out IMFPresentationDescriptor ppPresentationDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasource-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationDescriptor?>))] IMFPresentationDescriptor? pPresentationDescriptor, nint /* optional Guid* */ pguidTimeFormat, nint /* optional PROPVARIANT* */ pvarStartPosition);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasource-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasource-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasource-shutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
}
