﻿using ArxLibertatisEditorIO.RawIO.Shared;
using System.Runtime.InteropServices;

namespace ArxLibertatisEditorIO.RawIO.DLF
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct DLF_IO_PATHWAYS
    {
        public SavedVec3 rpos;
        public int flag;
        public uint time;
        public fixed float fpadd[2];
        public fixed int lpadd[2];
        public fixed byte cpadd[32];
    }
}
