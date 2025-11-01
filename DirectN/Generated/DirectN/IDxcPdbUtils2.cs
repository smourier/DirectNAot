#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("4315d938-f369-4f93-95a2-252017cc3807")]
public partial interface IDxcPdbUtils2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] IDxcBlob pPdbOrDxil);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSource(uint uIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobEncoding>))] out IDxcBlobEncoding ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceName(uint uIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobUtf16>))] out IDxcBlobUtf16 ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLibraryPDBCount(ref uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLibraryPDB(uint uIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcPdbUtils2>))] out IDxcPdbUtils2 ppOutPdbUtils, nint /* optional IDxcBlobUtf16* */ ppLibraryName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlagCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlag(uint uIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobUtf16>))] out IDxcBlobUtf16 ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetArgCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetArg(uint uIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobUtf16>))] out IDxcBlobUtf16 ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetArgPairCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetArgPair(uint uIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobUtf16>))] out IDxcBlobUtf16 ppName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobUtf16>))] out IDxcBlobUtf16 ppValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefineCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefine(uint uIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobUtf16>))] out IDxcBlobUtf16 ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTargetProfile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobUtf16>))] out IDxcBlobUtf16 ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEntryPoint([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobUtf16>))] out IDxcBlobUtf16 ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMainFileName([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobUtf16>))] out IDxcBlobUtf16 ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHash([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] out IDxcBlob ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlobUtf16>))] out IDxcBlobUtf16 ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcVersionInfo>))] out IDxcVersionInfo ppVersionInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCustomToolchainID(out uint pID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCustomToolchainData([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] out IDxcBlob ppBlob);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWholeDxil([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] out IDxcBlob ppResult);
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsFullPDB();
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsPDBRef();
}
