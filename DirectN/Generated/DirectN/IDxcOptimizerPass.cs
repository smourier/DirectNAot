#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ae2cd79f-cc22-453f-9b6b-b124e7a5204c")]
public partial interface IDxcOptimizerPass
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOptionName(out PWSTR ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescription(out PWSTR ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOptionArgCount(out uint pCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOptionArgName(uint argIndex, out PWSTR ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOptionArgDescription(uint argIndex, out PWSTR ppResult);
}
