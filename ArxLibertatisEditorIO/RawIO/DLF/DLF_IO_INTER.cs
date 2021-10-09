﻿using ArxLibertatisEditorIO.RawIO.Shared;
using System.Runtime.InteropServices;

namespace ArxLibertatisEditorIO.RawIO.DLF
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DLF_IO_INTER
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public byte[] name;
        public SavedVec3 pos;
        public SavedAnglef angle;
        public int ident;
        public int flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public int[] ipad;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public float[] fpad;
    }
}