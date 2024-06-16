#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmwritersink
[GeneratedComInterface, Guid("96406be4-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMWriterSink
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwritersink-onheader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnHeader(INSSBuffer pHeader);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwritersink-isrealtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsRealTime(out BOOL pfRealTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwritersink-allocatedataunit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocateDataUnit(uint cbDataUnit, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<INSSBuffer>))] out INSSBuffer ppDataUnit);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwritersink-ondataunit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDataUnit(INSSBuffer pDataUnit);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwritersink-onendwriting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnEndWriting();
}
