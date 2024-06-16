#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("7241d424-2646-4191-97c0-98e96e42fc68")]
public partial interface IDxcBlobEncoding : IDxcBlob
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEncoding(out BOOL pKnown, out DXC_CP pCodePage);
}
