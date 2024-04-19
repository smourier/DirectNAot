namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ne-d2d1_1-d2d1_layer_options1
[Flags]
public enum D2D1_LAYER_OPTIONS1
{
    D2D1_LAYER_OPTIONS1_NONE = 0,
    D2D1_LAYER_OPTIONS1_INITIALIZE_FROM_BACKGROUND = 1,
    D2D1_LAYER_OPTIONS1_IGNORE_ALPHA = 2,
}
