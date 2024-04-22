namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/documenttarget/ne-documenttarget-printdocumentpackagecompletion
public enum PrintDocumentPackageCompletion
{
    PrintDocumentPackageCompletion_InProgress = 0,
    PrintDocumentPackageCompletion_Completed = 1,
    PrintDocumentPackageCompletion_Canceled = 2,
    PrintDocumentPackageCompletion_Failed = 3,
}
