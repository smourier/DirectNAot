namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CPSUICBPARAM
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public int OldSel;
        
        [FieldOffset(0)]
        public nint pOldSel;
    }
    
    public ushort cbSize;
    public ushort Reason;
    public HWND hDlg;
    public nint pOptItem;
    public ushort cOptItem;
    public ushort Flags;
    public nint pCurItem;
    public _Anonymous_e__Union Anonymous;
    public nuint UserData;
    public nuint Result;
}
