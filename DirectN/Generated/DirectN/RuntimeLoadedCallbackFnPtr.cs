#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void RuntimeLoadedCallbackFnPtr(nint /* ICLRRuntimeInfo */ pRuntimeInfo, nint /* CallbackThreadSetFnPtr */ pfnCallbackThreadSet, nint /* CallbackThreadUnsetFnPtr */ pfnCallbackThreadUnset);
