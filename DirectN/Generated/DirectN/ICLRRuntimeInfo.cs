#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("bd39d1d2-ba2f-486a-89b0-b4b0cb466891")]
public partial interface ICLRRuntimeInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionString([MarshalUsing(CountElementName = nameof(pcchBuffer))] PWSTR pwzBuffer, ref uint pcchBuffer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRuntimeDirectory([MarshalUsing(CountElementName = nameof(pcchBuffer))] PWSTR pwzBuffer, ref uint pcchBuffer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsLoaded(HANDLE hndProcess, out BOOL pbLoaded);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadErrorString(uint iResourceID, [MarshalUsing(CountElementName = nameof(pcchBuffer))] PWSTR pwzBuffer, ref uint pcchBuffer, int iLocaleID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadLibraryA(PWSTR pwzDllName, out HMODULE phndModule);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcAddress(PSTR pszProcName, out nint ppProc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInterface(in Guid rclsid, in Guid riid, out nint /* void */ ppUnk);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsLoadable(out BOOL pbLoadable);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultStartupFlags(uint dwStartupFlags, PWSTR pwzHostConfigFile);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultStartupFlags(out uint pdwStartupFlags, [MarshalUsing(CountElementName = nameof(pcchHostConfigFile))] PWSTR pwzHostConfigFile, ref uint pcchHostConfigFile);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindAsLegacyV2Runtime();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsStarted(out BOOL pbStarted, out uint pdwStartupFlags);
}
