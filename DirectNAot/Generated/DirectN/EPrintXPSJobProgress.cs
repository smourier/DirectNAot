namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/eprintxpsjobprogress
public enum EPrintXPSJobProgress
{
    kAddingDocumentSequence = 0,
    kDocumentSequenceAdded = 1,
    kAddingFixedDocument = 2,
    kFixedDocumentAdded = 3,
    kAddingFixedPage = 4,
    kFixedPageAdded = 5,
    kResourceAdded = 6,
    kFontAdded = 7,
    kImageAdded = 8,
    kXpsDocumentCommitted = 9,
}
