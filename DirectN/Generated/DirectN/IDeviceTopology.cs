﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-idevicetopology
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("2a07407e-6497-4a18-9787-32f79bd0d98f")]
public partial interface IDeviceTopology
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-idevicetopology-getconnectorcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConnectorCount(out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-idevicetopology-getconnector
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConnector(uint nIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IConnector>))] out IConnector ppConnector);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-idevicetopology-getsubunitcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubunitCount(out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-idevicetopology-getsubunit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubunit(uint nIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISubunit>))] out ISubunit ppSubunit);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-idevicetopology-getpartbyid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPartById(uint nId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPart>))] out IPart ppPart);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-idevicetopology-getdeviceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceId(out PWSTR ppwstrDeviceId);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-idevicetopology-getsignalpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignalPath([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPart>))] IPart pIPartFrom, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPart>))] IPart pIPartTo, BOOL bRejectMixedPaths, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPartsList>))] out IPartsList ppParts);
}
