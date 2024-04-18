namespace DirectN;

[GeneratedComInterface, Guid("91c7765f-ed57-49ad-8b01-dc24816a5294")]
public partial interface IPrinterScriptablePropertyBag : IDispatch
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
    public HRESULT GetBytes(BSTR bstrName, out IDispatch ppArray);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBytes(BSTR bstrName, IDispatch pArray);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetReadStream(BSTR bstrName, out IPrinterScriptableStream ppStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetWriteStream(BSTR bstrName, out IPrinterScriptableStream ppStream);
}
