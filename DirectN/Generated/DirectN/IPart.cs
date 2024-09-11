#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-ipart
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("ae2de0e4-5bca-4f2d-aa46-5d13f8fdb3a9")]
public partial interface IPart
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipart-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out PWSTR ppwstrName);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipart-getlocalid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocalId(out uint pnId);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipart-getglobalid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlobalId(out PWSTR ppwstrGlobalId);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipart-getparttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPartType(out PartType pPartType);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipart-getsubtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubType(out Guid pSubType);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipart-getcontrolinterfacecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetControlInterfaceCount(out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipart-getcontrolinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetControlInterface(uint nIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IControlInterface>))] out IControlInterface ppInterfaceDesc);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipart-enumpartsincoming
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumPartsIncoming([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPartsList>))] out IPartsList ppParts);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipart-enumpartsoutgoing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumPartsOutgoing([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPartsList>))] out IPartsList ppParts);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipart-gettopologyobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTopologyObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDeviceTopology>))] out IDeviceTopology ppTopology);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipart-activate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Activate(uint dwClsContext, in Guid refiid, nint /* optional void** */ ppvObject);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipart-registercontrolchangecallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterControlChangeCallback(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IControlChangeNotify>))] IControlChangeNotify pNotify);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipart-unregistercontrolchangecallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterControlChangeCallback([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IControlChangeNotify>))] IControlChangeNotify pNotify);
}
