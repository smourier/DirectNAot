namespace DirectN;

[GeneratedComInterface, Guid("baecb0bd-a946-4771-bc30-e8b24f8d45c1")]
public partial interface IPrintSchemaOptionCollection : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_Count(out uint pulCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAt(uint ulIndex, out IPrintSchemaOption ppOption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get__NewEnum(out nint ppUnk);
}
