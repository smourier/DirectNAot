﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/ne-segment-dvdtextstringtype
public enum DVDTextStringType
{
    dvdStruct_Volume = 1,
    dvdStruct_Title = 2,
    dvdStruct_ParentalID = 3,
    dvdStruct_PartOfTitle = 4,
    dvdStruct_Cell = 5,
    dvdStream_Audio = 16,
    dvdStream_Subpicture = 17,
    dvdStream_Angle = 18,
    dvdChannel_Audio = 32,
    dvdGeneral_Name = 48,
    dvdGeneral_Comments = 49,
    dvdTitle_Series = 56,
    dvdTitle_Movie = 57,
    dvdTitle_Video = 58,
    dvdTitle_Album = 59,
    dvdTitle_Song = 60,
    dvdTitle_Other = 63,
    dvdTitle_Sub_Series = 64,
    dvdTitle_Sub_Movie = 65,
    dvdTitle_Sub_Video = 66,
    dvdTitle_Sub_Album = 67,
    dvdTitle_Sub_Song = 68,
    dvdTitle_Sub_Other = 71,
    dvdTitle_Orig_Series = 72,
    dvdTitle_Orig_Movie = 73,
    dvdTitle_Orig_Video = 74,
    dvdTitle_Orig_Album = 75,
    dvdTitle_Orig_Song = 76,
    dvdTitle_Orig_Other = 79,
    dvdOther_Scene = 80,
    dvdOther_Cut = 81,
    dvdOther_Take = 82,
}
