#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e6c9647e-9d6a-4c3b-b94c-524b5a6c343d")]
public partial interface IDxcPdbUtils
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load(IDxcBlob pPdbOrDxil);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSource(uint uIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobEncoding>))] out IDxcBlobEncoding ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceName(uint uIndex, out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlagCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlag(uint uIndex, out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetArgCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetArg(uint uIndex, out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetArgPairCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetArgPair(uint uIndex, out BSTR pName, out BSTR pValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefineCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefine(uint uIndex, out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTargetProfile(out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEntryPoint(out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMainFileName(out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHash([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] out IDxcBlob ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out BSTR pResult);
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsFullPDB();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFullPDB([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] out IDxcBlob ppFullPDB);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcVersionInfo>))] out IDxcVersionInfo ppVersionInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCompiler(IDxcCompiler3 pCompiler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompileForFullPDB([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcResult>))] out IDxcResult ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OverrideArgs(in DxcArgPair pArgPairs, uint uNumArgPairs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OverrideRootSignature(PWSTR pRootSignature);
}
