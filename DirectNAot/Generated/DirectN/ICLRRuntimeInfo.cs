#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("bd39d1d2-ba2f-486a-89b0-b4b0cb466891")]
public partial interface ICLRRuntimeInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcAddress(PSTR pszProcName, out nint ppProc);
}
