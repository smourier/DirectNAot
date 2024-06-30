#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ns-d2d1_1-d2d1_effect_input_description
public partial struct D2D1_EFFECT_INPUT_DESCRIPTION
{
    public nint effect;
    public uint inputIndex;
    public D2D_RECT_F inputRectangle;
}
