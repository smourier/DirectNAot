namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1
{
    public uint NodeMask;
    public nint pOutputStreamDesc;
    public uint NumInputStreamDescs;
    public nint pInputStreamDescs;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Protected;
    public ulong MemoryPoolL0Size;
    public ulong MemoryPoolL1Size;
}
