#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmt_colorspaceinfo_extension_data
public partial struct WMT_COLORSPACEINFO_EXTENSION_DATA
{
    public byte ucColorPrimaries;
    public byte ucColorTransferChar;
    public byte ucColorMatrixCoef;
}
