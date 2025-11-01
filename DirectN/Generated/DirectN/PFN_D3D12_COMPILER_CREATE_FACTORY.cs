#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_D3D12_COMPILER_CREATE_FACTORY(PWSTR pPluginCompilerDllPath, nint /* in Guid */ riid, nint ppFactory);
