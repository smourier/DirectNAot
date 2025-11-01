#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void D3D12ApplicationDescFunc(nint /* in D3D12_APPLICATION_DESC */ pApplicationDesc, nint pContext);
