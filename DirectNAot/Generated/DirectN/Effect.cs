namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/functions
[StructLayout(LayoutKind.Sequential)]
public partial struct Effect
{
    public nint lpVtbl;
    public nint nativeEffect;
    public int auxDataSize;
    public nint auxData;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool useAuxData;
}
