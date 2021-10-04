﻿using ArxLibertatisEditorIO.IO.Shared_IO;
using System.Runtime.InteropServices;

namespace ArxLibertatisEditorIO.IO.FTL
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EERIE_OLD_VERTEX
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] unused;
        public SavedVec3 vert;
        public SavedVec3 norm;
    }
}