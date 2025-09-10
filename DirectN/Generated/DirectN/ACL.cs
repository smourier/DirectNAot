#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winnt/ns-winnt-acl
public partial struct ACL
{
    public byte AclRevision;
    public byte Sbz1;
    public ushort AclSize;
    public ushort AceCount;
    public ushort Sbz2;
}
