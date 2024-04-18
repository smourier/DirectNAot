namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct OPTITEM
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public int Sel;
        
        [FieldOffset(0)]
        public nint pSel;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public nint pExtChkBox;
        
        [FieldOffset(0)]
        public nint pExtPush;
    }
    
    public ushort cbSize;
    public byte Level;
    public byte DlgPageIdx;
    public uint Flags;
    public nuint UserData;
    public nint pName;
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public nint pOptType;
    public uint HelpIndex;
    public byte DMPubID;
    public byte UserItemID;
    public ushort wReserved;
    public nint pOIExt;
    public InlineArrayUIntPtr3 dwReserved;
}
