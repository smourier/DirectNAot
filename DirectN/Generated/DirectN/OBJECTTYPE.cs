#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/ne-tom-objecttype
public enum OBJECTTYPE
{
    tomSimpleText = 0,
    tomRuby = 1,
    tomHorzVert = 2,
    tomWarichu = 3,
    tomEq = 9,
    tomMath = 10,
    tomAccent = 10,
    tomBox = 11,
    tomBoxedFormula = 12,
    tomBrackets = 13,
    tomBracketsWithSeps = 14,
    tomEquationArray = 15,
    tomFraction = 16,
    tomFunctionApply = 17,
    tomLeftSubSup = 18,
    tomLowerLimit = 19,
    tomMatrix = 20,
    tomNary = 21,
    tomOpChar = 22,
    tomOverbar = 23,
    tomPhantom = 24,
    tomRadical = 25,
    tomSlashedFraction = 26,
    tomStack = 27,
    tomStretchStack = 28,
    tomSubscript = 29,
    tomSubSup = 30,
    tomSuperscript = 31,
    tomUnderbar = 32,
    tomUpperLimit = 33,
    tomObjectMax = 33,
}
