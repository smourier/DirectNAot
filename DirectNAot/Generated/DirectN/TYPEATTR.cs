#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-typeattr
[StructLayout(LayoutKind.Sequential)]
public partial struct TYPEATTR
{
    public Guid guid;
    public uint lcid;
    public uint dwReserved;
    public int memidConstructor;
    public int memidDestructor;
    public PWSTR lpstrSchema;
    public uint cbSizeInstance;
    public TYPEKIND typekind;
    public ushort cFuncs;
    public ushort cVars;
    public ushort cImplTypes;
    public ushort cbSizeVft;
    public ushort cbAlignment;
    public ushort wTypeFlags;
    public ushort wMajorVerNum;
    public ushort wMinorVerNum;
    public TYPEDESC tdescAlias;
    public IDLDESC idldescType;
}
