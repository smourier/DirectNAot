﻿#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDDENUMCALLBACKA(nint param0, PSTR param1, PSTR param2, nint param3);
