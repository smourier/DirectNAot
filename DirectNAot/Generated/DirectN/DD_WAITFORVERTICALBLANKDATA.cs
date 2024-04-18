namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_waitforverticalblankdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_WAITFORVERTICALBLANKDATA
{
    public nint lpDD;
    public uint dwFlags;
    public uint bIsInVB;
    public nuint hEvent;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint WaitForVerticalBlank;
}
