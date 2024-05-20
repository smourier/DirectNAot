#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-irecordinfo
[GeneratedComInterface, Guid("0000002f-0000-0000-c000-000000000046")]
public partial interface IRecordInfo
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-recordinit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RecordInit(nint pvNew);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-recordclear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RecordClear(nint pvExisting);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-recordcopy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RecordCopy(nint pvExisting, nint pvNew);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-getguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGuid(out Guid pguid);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-getsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSize(out uint pcbSize);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-gettypeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeInfo(out ITypeInfo ppTypeInfo);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-getfield
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetField(nint pvData, PWSTR szFieldName, out VARIANT pvarField);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-getfieldnocopy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFieldNoCopy(nint pvData, PWSTR szFieldName, out VARIANT pvarField, out nint ppvDataCArray);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-putfield
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutField(uint wFlags, nint pvData, PWSTR szFieldName, in VARIANT pvarField);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-putfieldnocopy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutFieldNoCopy(uint wFlags, nint pvData, PWSTR szFieldName, in VARIANT pvarField);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-getfieldnames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFieldNames(ref uint pcNames, [MarshalUsing(CountElementName = nameof(pcNames))] out BSTR[] rgBstrNames);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-ismatchingtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsMatchingType(IRecordInfo pRecordInfo);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-recordcreate
    [PreserveSig]
    nint RecordCreate();
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-recordcreatecopy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RecordCreateCopy(nint pvSource, out nint ppvDest);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-recorddestroy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RecordDestroy(nint pvRecord);
}
