#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAC3_ERROR_CONCEALMENT
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fRepeatPreviousBlock;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fErrorInCurrentBlock;
}
