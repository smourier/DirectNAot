#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-input
public partial struct INPUT
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public MOUSEINPUT mi;
        
        [FieldOffset(0)]
        public KEYBDINPUT ki;
        
        [FieldOffset(0)]
        public HARDWAREINPUT hi;
    }
    
    public INPUT_TYPE type;
    public _Anonymous_e__Union Anonymous;
}
