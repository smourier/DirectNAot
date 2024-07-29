#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("20ee9be9-cd57-49ab-8f6e-1d07aeb8e482")]
public partial interface IDvbTerrestrial2DeliverySystemDescriptor
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTagExtension(nint /* byte array */ pbVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCentreFrequency(out uint pdwVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPLPId(nint /* byte array */ pbVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetT2SystemId(out ushort pwVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMultipleInputMode(nint /* byte array */ pbVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBandwidth(nint /* byte array */ pbVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGuardInterval(nint /* byte array */ pbVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransmissionMode(nint /* byte array */ pbVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellId(out ushort pwVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOtherFrequencyFlag(nint /* byte array */ pbVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTFSFlag(nint /* byte array */ pbVal);
}
