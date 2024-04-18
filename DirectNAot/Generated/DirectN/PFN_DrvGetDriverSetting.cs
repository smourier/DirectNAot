namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvGetDriverSetting(nint pdriverobj, PSTR Feature, nint pOutput, uint cbSize, nint pcbNeeded, nint pdwOptionsReturned);
