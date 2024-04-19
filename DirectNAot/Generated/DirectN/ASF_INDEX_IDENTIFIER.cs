namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/ns-wmcontainer-asf_index_identifier
[StructLayout(LayoutKind.Sequential)]
public partial struct ASF_INDEX_IDENTIFIER
{
    public Guid guidIndexType;
    public ushort wStreamNumber;
}
