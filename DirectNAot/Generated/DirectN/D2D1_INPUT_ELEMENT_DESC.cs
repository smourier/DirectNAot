namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/ns-d2d1effectauthor-d2d1_input_element_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_INPUT_ELEMENT_DESC
{
    public PSTR semanticName;
    public uint semanticIndex;
    public DXGI_FORMAT format;
    public uint inputSlot;
    public uint alignedByteOffset;
}
