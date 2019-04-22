using Demoder.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demoder.AnarchyData.FuncomTexture
{
    public class FcTx
    {
        [StreamData(0, Entries=4)]
        public byte[] Magic { get; set; }

        [StreamData(10)]
        public uint Unknown1 { get; set; }

        [StreamData(20)]
        public uint Unknown2 { get; set; }

        [StreamData(30)]
        public ushort Width { get; set; }

        [StreamData(40)]
        public ushort Height { get; set; }

        [StreamData(50)]
        public byte Mipmaps1 { get; set; }

        [StreamData(60)]
        public byte Mipmaps2 { get; set; }

        [StreamData(70)]
        public ushort Mipmaps3 { get; set; }

        [StreamData(80, Entries=4)]
        public byte[] FourCC { get; set; }
    }
}
