#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmregistereddevice
[GeneratedComInterface, Guid("a4503bec-5508-4148-97ac-bfa75760a70d")]
public partial interface IWMRegisteredDevice
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-getdeviceserialnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceSerialNumber(out DRM_VAL16 pSerialNumber);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-getdevicecertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceCertificate(out INSSBuffer ppCertificate);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-getdevicetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceType(out uint pdwType);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-getattributecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeCount(out uint pcAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-getattributebyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeByIndex(uint dwIndex, out BSTR pbstrName, out BSTR pbstrValue);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-getattributebyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeByName(BSTR bstrName, out BSTR pbstrValue);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-setattributebyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAttributeByName(BSTR bstrName, BSTR bstrValue);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-approve
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Approve([MarshalAs(UnmanagedType.U4)] bool fApprove);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-isvalid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsValid([MarshalAs(UnmanagedType.U4)] out bool pfValid);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-isapproved
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsApproved([MarshalAs(UnmanagedType.U4)] out bool pfApproved);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-iswmdrmcompliant
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsWmdrmCompliant([MarshalAs(UnmanagedType.U4)] out bool pfCompliant);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-isopened
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsOpened([MarshalAs(UnmanagedType.U4)] out bool pfOpened);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmregistereddevice-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
