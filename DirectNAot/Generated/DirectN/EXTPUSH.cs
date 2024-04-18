namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct EXTPUSH
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public nint DlgProc;
        
        [FieldOffset(0)]
        public nint pfnCallBack;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public ushort DlgTemplateID;
        
        [FieldOffset(0)]
        public HANDLE hDlgTemplate;
    }
    
    public ushort cbSize;
    public ushort Flags;
    public nint pTitle;
    public _Anonymous1_e__Union Anonymous1;
    public nuint IconID;
    public _Anonymous2_e__Union Anonymous2;
    public InlineArrayUIntPtr3 dwReserved;
}
