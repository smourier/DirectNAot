#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsensordevice
[SupportedOSPlatform("windows10.0.14393")]
[GeneratedComInterface, Guid("fb9f48f2-2a18-4e28-9730-786f30f04dc4")]
public partial interface IMFSensorDevice
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensordevice-getdeviceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceId(out ulong pDeviceId);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensordevice-getdevicetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceType(out MFSensorDeviceType pType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensordevice-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out ulong pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensordevice-getsymboliclink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSymbolicLink([MarshalUsing(CountElementName = nameof(cchSymbolicLink))] PWSTR SymbolicLink, int cchSymbolicLink, out int pcchWritten);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensordevice-getdeviceattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceAttributes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensordevice-getstreamattributescount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamAttributesCount(MFSensorStreamType eType, out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensordevice-getstreamattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamAttributes(MFSensorStreamType eType, uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensordevice-setsensordevicemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSensorDeviceMode(MFSensorDeviceMode eMode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensordevice-getsensordevicemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSensorDeviceMode(out MFSensorDeviceMode peMode);
}
