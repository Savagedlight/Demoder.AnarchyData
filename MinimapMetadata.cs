using Demoder.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demoder.AnarchyData
{
    public class MinimapMetadata
    {
        [StreamData(0)]
        public uint Bytes { get; set; }

        [StreamData(1)]
        public Identity XZibbitIdentity { get; set; }

        [StreamData(2)]
        public uint Unknown1 { get; set; }
        [StreamData(3)]
        public uint Unknown2 { get; set; }
        [StreamData(4)]
        public uint TextureSizeX { get; set; }
        [StreamData(5)]
        public uint TextureSizeY { get; set; }
        [StreamData(6)]
        public byte TilesX { get; set; }
        [StreamData(7)]
        public byte TilesY { get; set; }

        public uint[,] GetTextures()
        {
            uint[,] output = new uint[this.TilesY, this.TilesX];
            uint zoneId = this.XZibbitIdentity.Instance;
            for (uint y = 0; y < this.TilesY; y++)
            {
                for (uint x = 0; x < this.TilesX; x++)
                {
                    uint thisId = zoneId << 16;
                    thisId += x << 8;
                    thisId += y;
                    output[y, x] = thisId;
                }
            }
            return output;
        }
    }
}
