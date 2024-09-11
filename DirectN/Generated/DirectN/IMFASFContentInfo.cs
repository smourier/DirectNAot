#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/nn-wmcontainer-imfasfcontentinfo
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("b1dca5cd-d5da-4451-8e9e-db5c59914ead")]
public partial interface IMFASFContentInfo
{
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfcontentinfo-getheadersize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHeaderSize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] IMFMediaBuffer pIStartOfContent, out ulong cbHeaderSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfcontentinfo-parseheader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParseHeader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] IMFMediaBuffer pIHeaderBuffer, ulong cbOffsetWithinHeader);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfcontentinfo-generateheader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateHeader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] IMFMediaBuffer pIHeader, out uint pcbHeader);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfcontentinfo-getprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProfile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFProfile>))] out IMFASFProfile ppIProfile);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfcontentinfo-setprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProfile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFProfile>))] IMFASFProfile pIProfile);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfcontentinfo-generatepresentationdescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GeneratePresentationDescriptor([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationDescriptor>))] out IMFPresentationDescriptor ppIPresentationDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfcontentinfo-getencodingconfigurationpropertystore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEncodingConfigurationPropertyStore(ushort wStreamNumber, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] out IPropertyStore ppIStore);
}
