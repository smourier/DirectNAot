﻿#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool PFN_DrvPaint(nint param0, nint param1, nint param2, nint param3, uint param4);