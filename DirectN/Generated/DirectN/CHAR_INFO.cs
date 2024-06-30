#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/console/char-info-str
public partial struct CHAR_INFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Char_e__Union
    {
        [FieldOffset(0)]
        public char UnicodeChar;
        
        [FieldOffset(0)]
        public CHAR AsciiChar;
    }
    
    public _Char_e__Union Char;
    public ushort Attributes;
}
