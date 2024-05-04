#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/documenttarget/ns-documenttarget-printdocumentpackagestatus
[StructLayout(LayoutKind.Sequential)]
public partial struct PrintDocumentPackageStatus
{
    public uint JobId;
    public int CurrentDocument;
    public int CurrentPage;
    public int CurrentPageTotal;
    public PrintDocumentPackageCompletion Completion;
    public HRESULT PackageStatus;
}
