namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-idevicespecificproperty
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("3b22bcbf-2586-4af0-8583-205d391b807c")]
public partial interface IDeviceSpecificProperty
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-idevicespecificproperty-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out ushort pVType);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-idevicespecificproperty-getvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValue(nint pvValue, ref uint pcbValue);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-idevicespecificproperty-setvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetValue(nint pvValue, uint cbValue, nint /* optional Guid */ pguidEventContext);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-idevicespecificproperty-get4brange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Get4BRange(out int plMin, out int plMax, out int plStepping);
}
