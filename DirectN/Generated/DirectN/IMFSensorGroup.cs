#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsensorgroup
[SupportedOSPlatform("windows10.0.14393")]
[GeneratedComInterface, Guid("4110243a-9757-461f-89f1-f22345bcab4e")]
public partial interface IMFSensorGroup
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorgroup-getsymboliclink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSymbolicLink([MarshalUsing(CountElementName = nameof(cchSymbolicLink))] PWSTR SymbolicLink, int cchSymbolicLink, out int pcchWritten);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorgroup-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out ulong pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorgroup-getsensorgroupattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSensorGroupAttributes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorgroup-getsensordevicecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSensorDeviceCount(out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorgroup-getsensordevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSensorDevice(uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSensorDevice>))] out IMFSensorDevice ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorgroup-setdefaultsensordeviceindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultSensorDeviceIndex(uint dwIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorgroup-getdefaultsensordeviceindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultSensorDeviceIndex(out uint pdwIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorgroup-createmediasource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMediaSource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSource>))] out IMFMediaSource ppSource);
}
