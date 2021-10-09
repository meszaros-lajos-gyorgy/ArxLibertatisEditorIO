﻿using ArxLibertatisEditorIO.RawIO.FTS;
using ArxLibertatisEditorIO.Util;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ArxLibertatisEditorIO.MediumIO.FTS
{
    public class Anchor
    {
        public Vector3 pos;
        public float radius;
        public float height;
        public short flags; //TODO: enum
        public readonly List<int> linkedAnchors = new List<int>();

        internal void ReadFrom(FTS_IO_ANCHOR anchor)
        {
            pos = anchor.data.pos.ToVector3();
            radius = anchor.data.radius;
            height = anchor.data.height;
            flags = anchor.data.flags;
            linkedAnchors.Clear();
            linkedAnchors.AddRange(anchor.linkedAnchors);
        }

        internal void WriteTo(FTS_IO_ANCHOR anchor)
        {
            anchor.data.pos = new RawIO.Shared.SavedVec3(pos);
            anchor.data.radius = radius;
            anchor.data.height = height;
            anchor.data.flags = flags;
            anchor.data.nb_linked = (short)linkedAnchors.Count;
            IOHelper.EnsureArraySize(ref anchor.linkedAnchors, linkedAnchors.Count);
            for (int i = 0; i < linkedAnchors.Count; ++i)
            {
                anchor.linkedAnchors[i] = linkedAnchors[i];
            }
        }
    }
}