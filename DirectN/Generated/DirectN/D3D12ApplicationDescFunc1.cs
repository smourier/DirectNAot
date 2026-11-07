#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void D3D12ApplicationDescFunc1(nint /* in D3D12_APPLICATION_DESC */ pApplicationDesc, nint /* in Guid */ AppId, nint pContext);
