namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DLGPAGE
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public ushort DlgTemplateID;
        
        [FieldOffset(0)]
        public HANDLE hDlgTemplate;
    }
    
    public ushort cbSize;
    public ushort Flags;
    public nint DlgProc;
    public nint pTabName;
    public nuint IconID;
    public _Anonymous_e__Union Anonymous;
}
