using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сards
{
    public class GraphicCard:Card
    {
        public GraphicCard(CardColour colour, KindsOfCards kinds) : base(colour, kinds) {  }

        public PictureBox Pb { get; set; }

        public override void Show()
        {
            var exePath = AppDomain.CurrentDomain.BaseDirectory;//path to exe file
            var path1 = Path.Combine(exePath, @"images/" + Kinds.ToString() + " " + Colour.ToString()+".png");
            Pb.ImageLocation = path1;
        }
    }
}
