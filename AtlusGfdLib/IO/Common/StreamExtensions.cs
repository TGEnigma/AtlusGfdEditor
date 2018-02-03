﻿using System.IO;

namespace AtlusGfdLibrary.IO.Common
{
    public static class StreamExtensions
    {
        public static StreamView CreateSubView(this Stream stream, long position, long length)
        {
            return new StreamView(stream, position, length);
        }
    }
}
