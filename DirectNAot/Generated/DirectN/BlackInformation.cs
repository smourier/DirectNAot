namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wcsplugin/ns-wcsplugin-blackinformation
[StructLayout(LayoutKind.Sequential)]
public partial struct BlackInformation
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fBlackOnly;
    public float blackWeight;
}
