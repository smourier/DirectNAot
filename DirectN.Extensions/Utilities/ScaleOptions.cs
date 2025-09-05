namespace DirectN.Extensions.Utilities;

[Flags]
public enum ScaleOptions
{
    None = 0x0,
    DownOnly = 0x1,
    UpOnly = 0x2,
    Uniform = 0x4,
    UniformToFill = 0x8,

    Default = Uniform,
}
