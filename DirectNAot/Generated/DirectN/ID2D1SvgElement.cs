﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1svg/nn-d2d1svg-id2d1svgelement
[GeneratedComInterface, Guid("ac7b67a6-183e-49c1-a823-0ebe40b0db29")]
public partial interface ID2D1SvgElement : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getdocument
    [PreserveSig]
    void GetDocument(out ID2D1SvgDocument document);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-gettagname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTagName(out PWSTR name, uint nameCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-gettagnamelength
    [PreserveSig]
    uint GetTagNameLength();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-istextcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsTextContent();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getparent
    [PreserveSig]
    void GetParent(out ID2D1SvgElement parent);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-haschildren
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool HasChildren();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getfirstchild
    [PreserveSig]
    void GetFirstChild(out ID2D1SvgElement child);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getlastchild
    [PreserveSig]
    void GetLastChild(out ID2D1SvgElement child);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getpreviouschild
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreviousChild(ID2D1SvgElement referenceChild, out ID2D1SvgElement previousChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getnextchild
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextChild(ID2D1SvgElement referenceChild, out ID2D1SvgElement nextChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-insertchildbefore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertChildBefore(ID2D1SvgElement newChild, ID2D1SvgElement? referenceChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-appendchild
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppendChild(ID2D1SvgElement newChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-replacechild
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReplaceChild(ID2D1SvgElement newChild, ID2D1SvgElement oldChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-removechild
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveChild(ID2D1SvgElement oldChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-createchild
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateChild(PWSTR tagName, out ID2D1SvgElement newChild);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-isattributespecified
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsAttributeSpecified(PWSTR name, nint /* optional bool */ inherited);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getspecifiedattributecount
    [PreserveSig]
    uint GetSpecifiedAttributeCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getspecifiedattributename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpecifiedAttributeName(uint index, out PWSTR name, uint nameCount, nint /* optional bool */ inherited);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getspecifiedattributenamelength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpecifiedAttributeNameLength(uint index, out uint nameLength, nint /* optional bool */ inherited);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-removeattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAttribute(PWSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-settextvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTextValue(PWSTR name, uint nameCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-gettextvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextValue(out PWSTR name, uint nameCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-gettextvaluelength
    [PreserveSig]
    uint GetTextValueLength();
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgelement-setattributevalue-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAttributeValue(PWSTR name, ID2D1SvgAttribute value);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgelement-setattributevalue-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAttributeValue(PWSTR name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, nint value, uint valueSizeInBytes);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgelement-setattributevalue-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAttributeValue(PWSTR name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, PWSTR value);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgelement-getattributevalue-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeValue(PWSTR name, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ value);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgelement-getattributevalue-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeValue(PWSTR name, D2D1_SVG_ATTRIBUTE_POD_TYPE type, nint value, uint valueSizeInBytes);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgelement-getattributevalue-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeValue(PWSTR name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, out PWSTR value, uint valueCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgelement-getattributevaluelength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeValueLength(PWSTR name, D2D1_SVG_ATTRIBUTE_STRING_TYPE type, out uint valueLength);
}
