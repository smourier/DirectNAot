﻿namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvPaint(nint param0, nint param1, nint param2, nint param3, uint param4);