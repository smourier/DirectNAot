namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wtypes/ns-wtypes-cy~r1
[StructLayout(LayoutKind.Explicit)]
public partial struct CY
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _Anonymous_e__Struct
    {
        public uint Lo;
        public int Hi;
    }
    
    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;
    
    [FieldOffset(0)]
    public long int64;
}
