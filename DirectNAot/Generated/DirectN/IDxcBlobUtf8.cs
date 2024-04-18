namespace DirectN;

[GeneratedComInterface, Guid("3da636c9-ba71-4024-a301-30cbf125305b")]
public partial interface IDxcBlobUtf8 : IDxcBlobEncoding
{
    [PreserveSig]
    public PSTR GetStringPointer();
    
    [PreserveSig]
    public nuint GetStringLength();
}
