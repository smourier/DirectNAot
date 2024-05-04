﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcsx/ne-d3dcsx-d3dx11_scan_opcode
public enum D3DX11_SCAN_OPCODE
{
    D3DX11_SCAN_OPCODE_ADD = 1,
    D3DX11_SCAN_OPCODE_MIN = 2,
    D3DX11_SCAN_OPCODE_MAX = 3,
    D3DX11_SCAN_OPCODE_MUL = 4,
    D3DX11_SCAN_OPCODE_AND = 5,
    D3DX11_SCAN_OPCODE_OR = 6,
    D3DX11_SCAN_OPCODE_XOR = 7,
}
