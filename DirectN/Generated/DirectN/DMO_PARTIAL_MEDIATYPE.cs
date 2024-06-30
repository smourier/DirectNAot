#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dmoreg/ns-dmoreg-dmo_partial_mediatype
public partial struct DMO_PARTIAL_MEDIATYPE
{
    public Guid type;
    public Guid subtype;
}
