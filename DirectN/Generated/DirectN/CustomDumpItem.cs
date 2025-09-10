#nullable enable
namespace DirectN;

public partial struct CustomDumpItem
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nuint pReserved;
    }
    
    public ECustomDumpItemKind itemKind;
    public _Anonymous_e__Union Anonymous;
}
