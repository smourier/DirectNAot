﻿#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool PFN_DrvGradientFill(nint param0, nint param1, nint param2, nint param3, uint param4, nint param5, uint param6, nint param7, nint param8, uint param9);
