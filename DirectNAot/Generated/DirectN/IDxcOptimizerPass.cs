namespace DirectN;

[GeneratedComInterface, Guid("ae2cd79f-cc22-453f-9b6b-b124e7a5204c")]
public partial interface IDxcOptimizerPass
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOptionName(out PWSTR ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDescription(out PWSTR ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOptionArgCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOptionArgName(uint argIndex, out PWSTR ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOptionArgDescription(uint argIndex, out PWSTR ppResult);
}
