﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_bus_type
public enum D3D11_BUS_TYPE
{
    D3D11_BUS_TYPE_OTHER = 0,
    D3D11_BUS_TYPE_PCI = 1,
    D3D11_BUS_TYPE_PCIX = 2,
    D3D11_BUS_TYPE_PCIEXPRESS = 3,
    D3D11_BUS_TYPE_AGP = 4,
    D3D11_BUS_IMPL_MODIFIER_INSIDE_OF_CHIPSET = 65536,
    D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP = 131072,
    D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET = 196608,
    D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR = 262144,
    D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE = 327680,
    D3D11_BUS_IMPL_MODIFIER_NON_STANDARD = int.MinValue,
}
