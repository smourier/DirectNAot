﻿namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvSetPixelFormat(nint param0, int param1, HWND param2);
