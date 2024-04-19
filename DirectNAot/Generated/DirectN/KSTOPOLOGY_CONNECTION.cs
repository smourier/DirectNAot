namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vidcap/ns-vidcap-kstopology_connection
[StructLayout(LayoutKind.Sequential)]
public partial struct KSTOPOLOGY_CONNECTION
{
    public uint FromNode;
    public uint FromNodePin;
    public uint ToNode;
    public uint ToNodePin;
}
