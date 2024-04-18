namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-irecordinfo
[GeneratedComInterface, Guid("0000002f-0000-0000-c000-000000000046")]
public partial interface IRecordInfo
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-recordinit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RecordInit(nint pvNew);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-recordclear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RecordClear(nint pvExisting);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-recordcopy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RecordCopy(nint pvExisting, nint pvNew);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-getguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGuid(out Guid pguid);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetName(out BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-getsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSize(out uint pcbSize);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-gettypeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetTypeInfo(out ITypeInfo ppTypeInfo);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-getfield
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetField(nint pvData, PWSTR szFieldName, out VARIANT pvarField);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-getfieldnocopy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFieldNoCopy(nint pvData, PWSTR szFieldName, out VARIANT pvarField, out nint ppvDataCArray);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-putfield
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PutField(uint wFlags, nint pvData, PWSTR szFieldName, in VARIANT pvarField);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-putfieldnocopy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PutFieldNoCopy(uint wFlags, nint pvData, PWSTR szFieldName, in VARIANT pvarField);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-getfieldnames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFieldNames(ref uint pcNames, out BSTR rgBstrNames);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-ismatchingtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsMatchingType(IRecordInfo pRecordInfo);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-recordcreate
    [PreserveSig]
    public void RecordCreate();
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-recordcreatecopy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RecordCreateCopy(nint pvSource, out nint ppvDest);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-irecordinfo-recorddestroy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RecordDestroy(nint pvRecord);
}
