#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface_enums/ns-bdaiface_enums-smartcardapplication
public partial struct SmartCardApplication
{
    public ApplicationTypeType ApplicationType;
    public ushort ApplicationVersion;
    public BSTR pbstrApplicationName;
    public BSTR pbstrApplicationURL;
}
