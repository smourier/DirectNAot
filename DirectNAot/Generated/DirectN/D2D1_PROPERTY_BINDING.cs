namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/ns-d2d1effectauthor-d2d1_property_binding
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_PROPERTY_BINDING
{
    public PWSTR propertyName;
    public nint setFunction;
    public nint getFunction;
}
