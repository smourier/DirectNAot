﻿#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool PFN_DrvLineTo(nint param0, nint param1, nint param2, int param3, int param4, int param5, int param6, nint param7, uint param8);