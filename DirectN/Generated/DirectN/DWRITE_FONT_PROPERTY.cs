#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/ns-dwrite_3-dwrite_font_property
public partial struct DWRITE_FONT_PROPERTY
{
    public DWRITE_FONT_PROPERTY_ID propertyId;
    public PWSTR propertyValue;
    public PWSTR localeName;
}
