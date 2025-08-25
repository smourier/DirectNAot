#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("79eac9c0-baf9-11ce-8c82-00aa004ba90b")]
public partial interface IBinding
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Abort();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Suspend();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPriority(int nPriority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPriority(out int pnPriority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBindResult(out Guid pclsidProtocol, out uint pdwResult, out PWSTR pszResult, ref uint pdwReserved);
}
