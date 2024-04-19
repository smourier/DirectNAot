namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool LPFNEXTDEVIO(LPARAM lParam, uint dwFlags, uint dwIoControlCode, nint lpInBuffer, uint nInBufferSize, nint lpOutBuffer, uint nOutBufferSize, nint lpBytesReturned, nint lpOverlapped);
