#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11functionlinkinggraph
[GeneratedComInterface, Guid("54133220-1ce8-43d3-8236-9855c5ceecff")]
public partial interface ID3D11FunctionLinkingGraph
{
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionlinkinggraph-createmoduleinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateModuleInstance(out ID3D11ModuleInstance ppModuleInstance, nint /* optional ID3DBlob* */ ppErrorBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionlinkinggraph-setinputsignature
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInputSignature([MarshalUsing(CountElementName = nameof(cInputParameters))] in D3D11_PARAMETER_DESC[] pInputParameters, uint cInputParameters, out ID3D11LinkingNode ppInputNode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionlinkinggraph-setoutputsignature
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputSignature([MarshalUsing(CountElementName = nameof(cOutputParameters))] in D3D11_PARAMETER_DESC[] pOutputParameters, uint cOutputParameters, out ID3D11LinkingNode ppOutputNode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionlinkinggraph-callfunction
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CallFunction(PSTR pModuleInstanceNamespace, ID3D11Module pModuleWithFunctionPrototype, PSTR pFunctionName, out ID3D11LinkingNode ppCallNode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionlinkinggraph-passvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PassValue(ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ID3D11LinkingNode pDstNode, int DstParameterIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionlinkinggraph-passvaluewithswizzle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PassValueWithSwizzle(ID3D11LinkingNode pSrcNode, int SrcParameterIndex, PSTR pSrcSwizzle, ID3D11LinkingNode pDstNode, int DstParameterIndex, PSTR pDstSwizzle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionlinkinggraph-getlasterror
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastError(nint /* optional ID3DBlob* */ ppErrorBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11functionlinkinggraph-generatehlsl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateHlsl(uint uFlags, out ID3DBlob ppBuffer);
}
