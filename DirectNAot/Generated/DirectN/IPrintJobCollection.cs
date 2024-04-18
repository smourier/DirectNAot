namespace DirectN;

[GeneratedComInterface, Guid("72b82a24-a598-4e87-895f-cdb23a49e9dc")]
public partial interface IPrintJobCollection : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_Count(out uint pulCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAt(uint ulIndex, out IPrintJob ppJob);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get__NewEnum(out nint ppUnk);
}
