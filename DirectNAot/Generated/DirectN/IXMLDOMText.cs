namespace DirectN;

[GeneratedComInterface, Guid("2933bf87-7b36-11d2-b20e-00c04f983e60")]
public partial interface IXMLDOMText : IXMLDOMCharacterData
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT splitText(int offset, out IXMLDOMText rightHandTextNode);
}
