namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct FSVIDEO_MODE_INFORMATION
{
    public VIDEO_MODE_INFORMATION VideoMode;
    public VIDEO_MEMORY_INFORMATION VideoMemory;
}
