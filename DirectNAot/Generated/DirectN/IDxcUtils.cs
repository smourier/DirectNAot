namespace DirectN;

[GeneratedComInterface, Guid("4605c4cb-2019-492a-ada4-65f20bb7d67f")]
public partial interface IDxcUtils
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBlobFromBlob(IDxcBlob pBlob, uint offset, uint length, out IDxcBlob ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBlobFromPinned(nint pData, uint size, DXC_CP codePage, out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT MoveToBlob(nint pData, IMalloc pIMalloc, uint size, DXC_CP codePage, out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBlob(nint pData, uint size, DXC_CP codePage, out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT LoadFile(PWSTR pFileName, nint/* nint */ pCodePage, out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateReadOnlyStreamFromBlob(IDxcBlob pBlob, out IStream ppStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDefaultIncludeHandler(out IDxcIncludeHandler ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBlobAsUtf8(IDxcBlob pBlob, out IDxcBlobUtf8 pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBlobAsUtf16(IDxcBlob pBlob, out IDxcBlobUtf16 pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDxilContainerPart(in DxcBuffer pShader, uint DxcPart, out nint ppPartData, out uint pPartSizeInBytes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateReflection(in DxcBuffer pData, in Guid iid, out nint ppvReflection);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT BuildArguments(PWSTR pSourceName, PWSTR pEntryPoint, PWSTR pTargetProfile, nint/* nint */ pArguments, uint argCount, in DxcDefine pDefines, uint defineCount, out IDxcCompilerArgs ppArgs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPDBContents(IDxcBlob pPDBBlob, out IDxcBlob ppHash, out IDxcBlob ppContainer);
}
