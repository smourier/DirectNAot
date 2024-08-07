﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1svg/nn-d2d1svg-id2d1svgpathdata
[GeneratedComInterface, Guid("c095e4f4-bb98-43d6-9745-4d1b84ec9888")]
public partial interface ID2D1SvgPathData : ID2D1SvgAttribute
{
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpathdata-removesegmentdataatend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveSegmentDataAtEnd(uint dataCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpathdata-updatesegmentdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateSegmentData([In][MarshalUsing(CountElementName = nameof(dataCount))] float[] data, uint dataCount, uint startIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpathdata-getsegmentdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSegmentData([In][Out][MarshalUsing(CountElementName = nameof(dataCount))] float[] data, uint dataCount, uint startIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpathdata-getsegmentdatacount
    [PreserveSig]
    uint GetSegmentDataCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpathdata-removecommandsatend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveCommandsAtEnd(uint commandsCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpathdata-updatecommands
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateCommands([In][MarshalUsing(CountElementName = nameof(commandsCount))] D2D1_SVG_PATH_COMMAND[] commands, uint commandsCount, uint startIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpathdata-getcommands
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCommands([In][Out][MarshalUsing(CountElementName = nameof(commandsCount))] D2D1_SVG_PATH_COMMAND[] commands, uint commandsCount, uint startIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpathdata-getcommandscount
    [PreserveSig]
    uint GetCommandsCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpathdata-createpathgeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePathGeometry(D2D1_FILL_MODE fillMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1PathGeometry1>))] out ID2D1PathGeometry1 pathGeometry);
}
