namespace DirectN;

[GeneratedComInterface, Guid("292515f9-b54b-489b-9275-bab56821395e")]
public partial interface IPrintOemUI2 : IPrintOemUI
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT QueryJobAttributes(HANDLE hPrinter, in DEVMODEA pDevmode, uint dwLevel, nint /* byte array */ lpAttributeInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT HideStandardUI(uint dwMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DocumentEvent(HANDLE hPrinter, HDC hdc, int iEsc, uint cbIn, nint pvIn, uint cbOut, nint pvOut, ref int piResult);
}
