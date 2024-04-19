namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRELATIVEEVENT
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public HANDLE ObjectHandle;
        
        [FieldOffset(0)]
        public nint ObjectPointer;
    }
    
    public uint Size;
    public uint Flags;
    public _Anonymous_e__Union Anonymous;
    public nint Reserved;
    public KSIDENTIFIER Event;
    public KSEVENTDATA EventData;
}
