#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/ns-wmcodecdsp-toc_descriptor
public partial struct TOC_DESCRIPTOR
{
    public Guid guidID;
    public ushort wStreamNumber;
    public Guid guidType;
    public ushort wLanguageIndex;
}
