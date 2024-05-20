#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a3f84eab-0faa-497e-a39c-ee6ed60b2d84")]
public partial interface IDxcBlobUtf16 : IDxcBlobEncoding
{
    [PreserveSig]
    PWSTR GetStringPointer();
    
    [PreserveSig]
    nuint GetStringLength();
}
