#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsensortransformfactory
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("eed9c2ee-66b4-4f18-a697-ac7d3960215c")]
public partial interface IMFSensorTransformFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFactoryAttributes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensortransformfactory-initializefactory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFactory(uint dwMaxTransformCount, IMFCollection pSensorDevices, IMFAttributes? pAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensortransformfactory-gettransformcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransformCount(out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensortransformfactory-gettransforminformation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransformInformation(uint TransformIndex, out Guid pguidTransformId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCollection>))] out IMFCollection ppStreamInformation);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensortransformfactory-createtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTransform(in Guid guidSensorTransformID, IMFAttributes? pAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFDeviceTransform>))] out IMFDeviceTransform ppDeviceMFT);
}
