namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GdiplusStartupInput
{
    public uint GdiplusVersion;
    public nint DebugEventCallback;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool SuppressBackgroundThread;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool SuppressExternalCodecs;
}
