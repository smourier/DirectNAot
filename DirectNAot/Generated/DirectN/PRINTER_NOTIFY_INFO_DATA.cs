namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-notify-info-data
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_NOTIFY_INFO_DATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _NotifyData_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Data_e__Struct
        {
            public uint cbBuf;
            public nint pBuf;
        }
        
        [FieldOffset(0)]
        public InlineArrayUInt322 adwData;
        
        [FieldOffset(0)]
        public _Data_e__Struct Data;
    }
    
    public ushort Type;
    public ushort Field;
    public uint Reserved;
    public uint Id;
    public _NotifyData_e__Union NotifyData;
}
