#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("4605c4cb-2019-492a-ada4-65f20bb7d67f")]
public partial interface IDxcUtils
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBlobFromBlob(IDxcBlob pBlob, uint offset, uint length, out IDxcBlob ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBlobFromPinned(nint pData, uint size, DXC_CP codePage, out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveToBlob(nint pData, IMalloc pIMalloc, uint size, DXC_CP codePage, out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBlob(nint pData, uint size, DXC_CP codePage, out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadFile(PWSTR pFileName, nint /* optional DXC_CP* */ pCodePage, out IDxcBlobEncoding pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateReadOnlyStreamFromBlob(IDxcBlob pBlob, out IStream ppStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDefaultIncludeHandler(out IDxcIncludeHandler ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBlobAsUtf8(IDxcBlob pBlob, out IDxcBlobUtf8 pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBlobAsUtf16(IDxcBlob pBlob, out IDxcBlobUtf16 pBlobEncoding);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDxilContainerPart(in DxcBuffer pShader, uint DxcPart, out nint ppPartData, out uint pPartSizeInBytes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateReflection(in DxcBuffer pData, in Guid iid, out nint ppvReflection);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BuildArguments(PWSTR pSourceName, PWSTR pEntryPoint, PWSTR pTargetProfile, nint /* optional PWSTR* */ pArguments, uint argCount, [In][MarshalUsing(CountElementName = nameof(defineCount))] DxcDefine[] pDefines, uint defineCount, out IDxcCompilerArgs ppArgs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPDBContents(IDxcBlob pPDBBlob, out IDxcBlob ppHash, out IDxcBlob ppContainer);
}
