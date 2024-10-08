﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("2424b3f2-eb23-40f1-91aa-74bddeea0883")]
public partial interface IMFVideoProcessorControl3 : IMFVideoProcessorControl2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNaturalOutputType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableSphericalVideoProcessing(BOOL fEnable, MFVideoSphericalFormat eFormat, MFVideoSphericalProjectionMode eProjectionMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSphericalVideoProperties(float X, float Y, float Z, float W, float fieldOfView);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputDevice(nint pOutputDevice);
}
