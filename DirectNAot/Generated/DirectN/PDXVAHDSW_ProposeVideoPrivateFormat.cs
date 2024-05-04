#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVAHDSW_ProposeVideoPrivateFormat(HANDLE hDevice, nint pFormat);
