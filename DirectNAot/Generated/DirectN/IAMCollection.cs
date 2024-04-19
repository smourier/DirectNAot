namespace DirectN;

[GeneratedComInterface, Guid("56a868b9-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IAMCollection : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int plCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int lItem, out nint ppUnk);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint ppUnk);
}
