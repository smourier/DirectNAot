﻿#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool PFN_DrvFillPath(nint param0, nint param1, nint param2, nint param3, nint param4, uint param5, uint param6);