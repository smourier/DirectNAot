﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_PictureParameters
{
    public ushort wDecodedPictureIndex;
    public ushort wDeblockedPictureIndex;
    public ushort wForwardRefPictureIndex;
    public ushort wBackwardRefPictureIndex;
    public ushort wPicWidthInMBminus1;
    public ushort wPicHeightInMBminus1;
    public byte bMacroblockWidthMinus1;
    public byte bMacroblockHeightMinus1;
    public byte bBlockWidthMinus1;
    public byte bBlockHeightMinus1;
    public byte bBPPminus1;
    public byte bPicStructure;
    public byte bSecondField;
    public byte bPicIntra;
    public byte bPicBackwardPrediction;
    public byte bBidirectionalAveragingMode;
    public byte bMVprecisionAndChromaRelation;
    public byte bChromaFormat;
    public byte bPicScanFixed;
    public byte bPicScanMethod;
    public byte bPicReadbackRequests;
    public byte bRcontrol;
    public byte bPicSpatialResid8;
    public byte bPicOverflowBlocks;
    public byte bPicExtrapolation;
    public byte bPicDeblocked;
    public byte bPicDeblockConfined;
    public byte bPic4MVallowed;
    public byte bPicOBMC;
    public byte bPicBinPB;
    public byte bMV_RPS;
    public byte bReservedBits;
    public ushort wBitstreamFcodes;
    public ushort wBitstreamPCEelements;
    public byte bBitstreamConcealmentNeed;
    public byte bBitstreamConcealmentMethod;
}
