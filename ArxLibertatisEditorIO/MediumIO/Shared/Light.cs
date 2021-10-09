﻿using ArxLibertatisEditorIO.RawIO.Shared;
using ArxLibertatisEditorIO.Util;
using System.Numerics;

namespace ArxLibertatisEditorIO.MediumIO.Shared
{
    public class Light
    {
        public Vector3 pos;
        public Color color;
        public float fallStart;
        public float fallEnd;
        public float intensity;
        public float i; //no idea what this does
        public Color ex_flicker;
        public float ex_radius;
        public float ex_frequency;
        public float ex_size;
        public float ex_speed;
        public float ex_flaresize;
        public int extras; //maybe bool or flags?

        internal void ReadFrom(DANAE_IO_LIGHT light)
        {
            pos = light.pos.ToVector3();
            color = light.rgb.ToColor();
            fallStart = light.fallStart;
            fallEnd = light.fallEnd;
            intensity = light.intensity;
            i = light.i;
            ex_flicker = light.ex_flicker.ToColor();
            ex_radius = light.ex_radius;
            ex_frequency = light.ex_frequency;
            ex_size = light.ex_size;
            ex_speed = light.ex_speed;
            ex_flaresize = light.ex_flaresize;
            extras = light.extras;
        }

        internal void WriteTo(DANAE_IO_LIGHT light)
        {

            light.pos = new SavedVec3(pos);
            light.rgb = new SavedColor(color);
            light.fallStart = fallStart;
            light.fallEnd = fallEnd;
            light.intensity = intensity;
            light.i = i;
            light.ex_flicker = new SavedColor(ex_flicker);
            light.ex_radius = ex_radius;
            light.ex_frequency = ex_frequency;
            light.ex_size = ex_size;
            light.ex_speed = ex_speed;
            light.ex_flaresize = ex_flaresize;
            light.extras = extras;

            IOHelper.EnsureArraySize(ref light.fpad, 24);
            IOHelper.EnsureArraySize(ref light.ipad, 31);
        }
    }
}