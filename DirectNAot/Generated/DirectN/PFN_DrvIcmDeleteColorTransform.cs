#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvIcmDeleteColorTransform(DHPDEV param0, HANDLE param1);
