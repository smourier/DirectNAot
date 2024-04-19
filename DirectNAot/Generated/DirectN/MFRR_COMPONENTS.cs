namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfrr_components
[StructLayout(LayoutKind.Sequential)]
public partial struct MFRR_COMPONENTS
{
    public uint dwRRInfoVersion;
    public uint dwRRComponents;
    public nint pRRComponents;
}
