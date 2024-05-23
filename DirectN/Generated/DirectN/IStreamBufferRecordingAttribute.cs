#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-istreambufferrecordingattribute
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("16ca4e03-fe69-4705-bd41-5b7dfc0c95f3")]
public partial interface IStreamBufferRecordingAttribute
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferrecordingattribute-setattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAttribute(uint ulReserved, PWSTR pszAttributeName, STREAMBUFFER_ATTR_DATATYPE StreamBufferAttributeType, nint /* byte array */ pbAttribute, ushort cbAttributeLength);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferrecordingattribute-getattributecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeCount(uint ulReserved, out ushort pcAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferrecordingattribute-getattributebyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeByName(PWSTR pszAttributeName, in uint pulReserved, out STREAMBUFFER_ATTR_DATATYPE pStreamBufferAttributeType, nint /* byte array */ pbAttribute, ref ushort pcbLength);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferrecordingattribute-getattributebyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeByIndex(ushort wIndex, in uint pulReserved, out PWSTR pszAttributeName, ref ushort pcchNameLength, out STREAMBUFFER_ATTR_DATATYPE pStreamBufferAttributeType, nint /* byte array */ pbAttribute, ref ushort pcbLength);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferrecordingattribute-enumattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAttributes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumStreamBufferRecordingAttrib>))] out IEnumStreamBufferRecordingAttrib ppIEnumStreamBufferAttrib);
}
