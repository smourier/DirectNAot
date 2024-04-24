﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imftopologynodeattributeeditor
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("676aa6dd-238a-410d-bb99-65668d01605a")]
public partial interface IMFTopologyNodeAttributeEditor
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftopologynodeattributeeditor-updatenodeattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateNodeAttributes(ulong TopoId, uint cUpdates, [MarshalUsing(CountElementName = nameof(cUpdates))] in MFTOPONODE_ATTRIBUTE_UPDATE[] pUpdates);
}
