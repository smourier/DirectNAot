namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1svg/nn-d2d1svg-id2d1svgelement
[GeneratedComInterface, Guid("ac7b67a6-183e-49c1-a823-0ebe40b0db29")]
public partial interface ID2D1SvgElement : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getdocument
    [PreserveSig]
    public void GetDocument(out ID2D1SvgDocument document);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-gettagname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetTagName(out PWSTR name, uint nameCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-gettagnamelength
    [PreserveSig]
    public uint GetTagNameLength();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-istextcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsTextContent();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getparent
    [PreserveSig]
    public void GetParent(out ID2D1SvgElement parent);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-haschildren
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool HasChildren();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getfirstchild
    [PreserveSig]
    public void GetFirstChild(out ID2D1SvgElement child);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getlastchild
    [PreserveSig]
    public void GetLastChild(out ID2D1SvgElement child);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getpreviouschild
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPreviousChild(ID2D1SvgElement referenceChild, out ID2D1SvgElement previousChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getnextchild
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetNextChild(ID2D1SvgElement referenceChild, out ID2D1SvgElement nextChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-insertchildbefore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT InsertChildBefore(ID2D1SvgElement newChild, ID2D1SvgElement referenceChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-appendchild
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AppendChild(ID2D1SvgElement newChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-replacechild
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ReplaceChild(ID2D1SvgElement newChild, ID2D1SvgElement oldChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-removechild
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RemoveChild(ID2D1SvgElement oldChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-createchild
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateChild(PWSTR tagName, out ID2D1SvgElement newChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-isattributespecified
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsAttributeSpecified(PWSTR name, nint /* bool */ inherited);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getspecifiedattributecount
    [PreserveSig]
    public uint GetSpecifiedAttributeCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getspecifiedattributename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSpecifiedAttributeName(uint index, out PWSTR name, uint nameCount, nint /* bool */ inherited);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getspecifiedattributenamelength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSpecifiedAttributeNameLength(uint index, out uint nameLength, nint /* bool */ inherited);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-removeattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RemoveAttribute(PWSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-settextvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTextValue(PWSTR name, uint nameCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-gettextvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetTextValue(out PWSTR name, uint nameCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-gettextvaluelength
    [PreserveSig]
    public uint GetTextValueLength();
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgelement-setattributevalue-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAttributeValue(PWSTR name, ID2D1SvgAttribute value);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgelement-setattributevalue-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAttributeValue(PWSTR name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, nint value, uint valueSizeInBytes);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgelement-setattributevalue-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAttributeValue(PWSTR name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, PWSTR value);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgelement-getattributevalue-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAttributeValue(PWSTR name, in Guid riid, out nint value);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgelement-getattributevalue-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAttributeValue(PWSTR name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, nint value, uint valueSizeInBytes);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgelement-getattributevalue-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAttributeValue(PWSTR name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, out PWSTR value, uint valueCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getattributevaluelength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAttributeValueLength(PWSTR name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, out uint valueLength);
}
