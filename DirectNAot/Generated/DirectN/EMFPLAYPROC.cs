namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int EMFPLAYPROC(HDC param0, int param1, HANDLE param2);
