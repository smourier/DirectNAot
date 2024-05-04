#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint VFWWDMExtensionProc(nint pfnDeviceIoControl, nint /* LPFNSVADDPROPSHEETPAGE */ pfnAddPropertyPage, LPARAM lParam);
