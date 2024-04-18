namespace DirectN;

[GeneratedComInterface, Guid("e6c9647e-9d6a-4c3b-b94c-524b5a6c343d")]
public partial interface IDxcPdbUtils
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Load(IDxcBlob pPdbOrDxil);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSourceCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSource(uint uIndex, out IDxcBlobEncoding ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSourceName(uint uIndex, out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFlagCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFlag(uint uIndex, out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetArgCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetArg(uint uIndex, out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetArgPairCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetArgPair(uint uIndex, out BSTR pName, out BSTR pValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDefineCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDefine(uint uIndex, out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetTargetProfile(out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetEntryPoint(out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMainFileName(out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetHash(out IDxcBlob ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetName(out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsFullPDB();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFullPDB(out IDxcBlob ppFullPDB);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVersionInfo(out IDxcVersionInfo ppVersionInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCompiler(IDxcCompiler3 pCompiler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CompileForFullPDB(out IDxcResult ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT OverrideArgs(in DxcArgPair pArgPairs, uint uNumArgPairs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT OverrideRootSignature(PWSTR pRootSignature);
}
