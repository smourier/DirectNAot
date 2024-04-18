namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvUpgradeRegistrySetting(HANDLE hPrinter, PSTR pFeature, PSTR pOption);
