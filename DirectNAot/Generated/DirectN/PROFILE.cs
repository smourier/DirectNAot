namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-profile
[StructLayout(LayoutKind.Sequential)]
public partial struct PROFILE
{
    public uint dwType;
    public nint pProfileData;
    public uint cbDataSize;
}
