#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AM_AC3_ERROR_CONCEALMENT
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fRepeatPreviousBlock;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fErrorInCurrentBlock;
}
