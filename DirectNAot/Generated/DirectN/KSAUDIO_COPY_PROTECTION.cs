#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIO_COPY_PROTECTION
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fCopyrighted;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fOriginal;
}
