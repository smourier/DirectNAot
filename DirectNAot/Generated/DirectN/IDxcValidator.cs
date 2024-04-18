namespace DirectN;

[GeneratedComInterface, Guid("a6e82bd2-1fd7-4826-9811-2857e797f49a")]
public partial interface IDxcValidator
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Validate(IDxcBlob pShader, uint Flags, out IDxcOperationResult ppResult);
}
