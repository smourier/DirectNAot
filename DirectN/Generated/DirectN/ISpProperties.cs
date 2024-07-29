#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5b4fb971-b115-4de1-ad97-e482e3bf6ee4")]
public partial interface ISpProperties
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPropertyNum(PWSTR pName, int lValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyNum(PWSTR pName, ref int plValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPropertyString(PWSTR pName, PWSTR pValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyString(PWSTR pName, out PWSTR ppCoMemValue);
}
