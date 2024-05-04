#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool EnumerateMetafileProc(EmfPlusRecordType param0, uint param1, uint param2, nint /* byte array */ param3, nint param4);
