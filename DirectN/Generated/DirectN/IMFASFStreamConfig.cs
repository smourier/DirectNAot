#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/nn-wmcontainer-imfasfstreamconfig
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("9e8ae8d2-dbbd-4200-9aca-06e6df484913")]
public partial interface IMFASFStreamConfig : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamconfig-getstreamtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamType(out Guid pguidStreamType);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamconfig-getstreamnumber
    [PreserveSig]
    ushort GetStreamNumber();
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamconfig-setstreamnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamNumber(ushort wStreamNum);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamconfig-getmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppIMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamconfig-setmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMediaType(IMFMediaType pIMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamconfig-getpayloadextensioncount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPayloadExtensionCount(out ushort pcPayloadExtensions);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamconfig-getpayloadextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPayloadExtension(ushort wPayloadExtensionNumber, out Guid pguidExtensionSystemID, out ushort pcbExtensionDataSize, nint /* byte array */ pbExtensionSystemInfo, ref uint pcbExtensionSystemInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamconfig-addpayloadextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPayloadExtension(Guid guidExtensionSystemID, ushort cbExtensionDataSize, nint /* byte array */ pbExtensionSystemInfo, uint cbExtensionSystemInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamconfig-removeallpayloadextensions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllPayloadExtensions();
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfstreamconfig-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFStreamConfig>))] out IMFASFStreamConfig ppIStreamConfig);
}
