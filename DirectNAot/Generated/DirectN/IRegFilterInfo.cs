#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("56a868bb-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IRegFilterInfo : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR strName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Filter(out IDispatch ppUnk);
}
