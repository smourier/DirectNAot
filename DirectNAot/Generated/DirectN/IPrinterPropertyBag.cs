namespace DirectN;

[GeneratedComInterface, Guid("fea77364-df95-4a23-a905-019b79a8e481")]
public partial interface IPrinterPropertyBag : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBool(BSTR bstrName, [MarshalAs(UnmanagedType.U4)] out bool pbValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBool(BSTR bstrName, [MarshalAs(UnmanagedType.U4)] bool bValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetInt32(BSTR bstrName, out int pnValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetInt32(BSTR bstrName, int nValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetString(BSTR bstrName, out BSTR pbstrValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetString(BSTR bstrName, BSTR bstrValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBytes(BSTR bstrName, out uint pcbValue, out nint /* byte array */ ppValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBytes(BSTR bstrName, uint cbValue, nint /* byte array */ pValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetReadStream(BSTR bstrName, out IStream ppValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetWriteStream(BSTR bstrName, out IStream ppValue);
}
