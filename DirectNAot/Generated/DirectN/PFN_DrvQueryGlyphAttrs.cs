namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate FD_GLYPHATTR PFN_DrvQueryGlyphAttrs(nint param0, uint param1);
