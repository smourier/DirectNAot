#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("d332db9e-b9b3-4125-8207-a14884f53216")]
public partial interface ICLRMetaHost
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRuntime(PWSTR pwzVersion, in Guid riid, out nint /* void */ ppRuntime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionFromFile(PWSTR pwzFilePath, [MarshalUsing(CountElementName = nameof(pcchBuffer))] PWSTR pwzBuffer, ref uint pcchBuffer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateInstalledRuntimes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumUnknown>))] out IEnumUnknown ppEnumerator);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateLoadedRuntimes(HANDLE hndProcess, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumUnknown>))] out IEnumUnknown ppEnumerator);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RequestRuntimeLoadedNotification(RuntimeLoadedCallbackFnPtr pCallbackFunction);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryLegacyV2RuntimeBinding(in Guid riid, out nint /* void */ ppUnk);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExitProcess(int iExitCode);
}
