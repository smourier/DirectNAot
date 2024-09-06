#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("56a868bc-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IMediaTypeInfo : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Type(out BSTR strType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Subtype(out BSTR strType);
}
