#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmdrmtranscryptor
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("69059850-6e6f-4bb2-806f-71863ddfc471")]
public partial interface IWMDRMTranscryptor
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmtranscryptor-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(BSTR bstrFileName, nint /* byte array */ pbLicenseRequestMsg, uint cbLicenseRequestMsg, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<INSSBuffer>))] out INSSBuffer ppLicenseResponseMsg, IWMStatusCallback pCallback, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmtranscryptor-seek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Seek(ulong hnsTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmtranscryptor-read
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Read(nint /* byte array */ pbData, in uint pcbData);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmtranscryptor-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
