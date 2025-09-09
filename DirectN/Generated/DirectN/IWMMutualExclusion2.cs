#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmmutualexclusion2
[GeneratedComInterface, Guid("0302b57d-89d1-4ba2-85c9-166f2c53eb91")]
public partial interface IWMMutualExclusion2 : IWMMutualExclusion
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmmutualexclusion2-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName([MarshalUsing(CountElementName = nameof(pcchName))] PWSTR pwszName, ref ushort pcchName);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmmutualexclusion2-setname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetName(PWSTR pwszName);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmmutualexclusion2-getrecordcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordCount(out ushort pwRecordCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmmutualexclusion2-addrecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRecord();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmmutualexclusion2-removerecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveRecord(ushort wRecordNumber);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmmutualexclusion2-getrecordname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordName(ushort wRecordNumber, [MarshalUsing(CountElementName = nameof(pcchRecordName))] PWSTR pwszRecordName, ref ushort pcchRecordName);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmmutualexclusion2-setrecordname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRecordName(ushort wRecordNumber, PWSTR pwszRecordName);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmmutualexclusion2-getstreamsforrecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamsForRecord(ushort wRecordNumber, [MarshalUsing(CountElementName = nameof(pcStreams))] out ushort[] pwStreamNumArray, ref ushort pcStreams);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmmutualexclusion2-addstreamforrecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddStreamForRecord(ushort wRecordNumber, ushort wStreamNumber);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmmutualexclusion2-removestreamforrecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveStreamForRecord(ushort wRecordNumber, ushort wStreamNumber);
}
