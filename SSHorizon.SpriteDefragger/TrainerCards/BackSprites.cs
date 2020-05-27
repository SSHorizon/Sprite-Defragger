using System.Collections.Generic;
using System.Drawing;

namespace SSHorizon.SpriteDefragger.TrainerCards
{
    public class BackSprites
    {
        private static int _frames = 8;
        private static int _width = 16;
        private static readonly Rectangle Sprite01MainLeft01Original = new Rectangle(0, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight01Original = new Rectangle(2 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft02Original = new Rectangle(4 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight02Original = new Rectangle(6 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft03Original = new Rectangle(8 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight03Original = new Rectangle(10 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft04Original = new Rectangle(12 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight04Original = new Rectangle(14 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft05Original = new Rectangle(16 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight05Original = new Rectangle(18 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft06Original = new Rectangle(20 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight06Original = new Rectangle(22 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft07Original = new Rectangle(24 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight07Original = new Rectangle(26 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft08Original = new Rectangle(28 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight08Original = new Rectangle(30 * _width, 0, 2 * _width, 8);

        private static readonly Rectangle Sprite01Stack01Original = new Rectangle(32 * _width, 0, _width, 8);
        private static readonly Rectangle Sprite01Stack02Original = new Rectangle(33 * _width, 0, _width, 8);
        private static readonly Rectangle Sprite01Stack03Original = new Rectangle(34 * _width, 0, _width, 8);
        private static readonly Rectangle Sprite01Stack04Original = new Rectangle(35 * _width, 0, _width, 8);
        private static readonly Rectangle Sprite01Stack05Original = new Rectangle(36 * _width, 0, _width, 8);
        private static readonly Rectangle Sprite01Stack06Original = new Rectangle(37 * _width, 0, _width, 8);
        private static readonly Rectangle Sprite01Stack07Original = new Rectangle(38 * _width, 0, _width, 8);
        private static readonly Rectangle Sprite01Stack08Original = new Rectangle(39 * _width, 0, _width, 8);

        private static readonly Rectangle Sprite01Bottom01Original = new Rectangle(40 * _width, 0, 2* _width, 8);
        private static readonly Rectangle Sprite01Bottom02Original = new Rectangle(42 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01Bottom03Original = new Rectangle(44 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01Bottom04Original = new Rectangle(46 * _width, 0, 2 * _width, 8);

        private static readonly Rectangle Sprite01Stack09Original = new Rectangle(48 * _width, 0, _width, 8);
        private static readonly Rectangle Sprite01Stack10Original = new Rectangle(49 * _width, 0,  _width, 8);


        private static readonly Rectangle Sprite01MainLeft01Solved = new Rectangle(0, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight01Solved = new Rectangle(2 * _width, 0, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft02Solved = new Rectangle(0, 8, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight02Solved = new Rectangle(2 * _width, 8, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft03Solved = new Rectangle(0, 16, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight03Solved = new Rectangle(2 * _width, 16, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft04Solved = new Rectangle(0, 24, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight04Solved = new Rectangle(2 * _width, 24, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft05Solved = new Rectangle(0, 32, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight05Solved = new Rectangle(2 * _width, 32, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft06Solved = new Rectangle(0, 40, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight06Solved = new Rectangle(2 * _width, 40, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft07Solved = new Rectangle(0, 48, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight07Solved = new Rectangle(2 * _width, 48, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainLeft08Solved = new Rectangle(0, 56, 2 * _width, 8);
        private static readonly Rectangle Sprite01MainRight08Solved = new Rectangle(2 * _width, 56, 2 * _width, 8);

        private static readonly Rectangle Sprite01Stack01Solved = new Rectangle(4 * _width, 0, _width, 8);
        private static readonly Rectangle Sprite01Stack02Solved = new Rectangle(4 * _width, 8, _width, 8);
        private static readonly Rectangle Sprite01Stack03Solved = new Rectangle(4 * _width, 16, _width, 8);
        private static readonly Rectangle Sprite01Stack04Solved = new Rectangle(4 * _width, 24, _width, 8);
        private static readonly Rectangle Sprite01Stack05Solved = new Rectangle(4 * _width, 32, _width, 8);
        private static readonly Rectangle Sprite01Stack06Solved = new Rectangle(4 * _width, 40, _width, 8);
        private static readonly Rectangle Sprite01Stack07Solved = new Rectangle(4 * _width, 48, _width, 8);
        private static readonly Rectangle Sprite01Stack08Solved = new Rectangle(4 * _width, 56, _width, 8);

        private static readonly Rectangle Sprite01Bottom01Solved = new Rectangle(0, 64, 2 * _width, 8);
        private static readonly Rectangle Sprite01Bottom02Solved = new Rectangle(0, 72, 2 * _width, 8);
        private static readonly Rectangle Sprite01Bottom03Solved = new Rectangle(2 * _width, 64, 2 * _width, 8);
        private static readonly Rectangle Sprite01Bottom04Solved = new Rectangle(2 * _width, 72, 2 * _width, 8);

        private static readonly Rectangle Sprite01Stack09Solved = new Rectangle(4 * _width, 64, _width, 8);
        private static readonly Rectangle Sprite01Stack10Solved = new Rectangle(4 * _width, 72, _width, 8);

        public static List<Rectangle> Originals()
        {
            List<Rectangle> output = new List<Rectangle>();
            List<Rectangle> originals = new List<Rectangle>
            {
                Sprite01MainLeft01Original, Sprite01MainLeft02Original, Sprite01MainLeft03Original, Sprite01MainLeft04Original,
                Sprite01MainLeft05Original, Sprite01MainLeft06Original, Sprite01MainLeft07Original, Sprite01MainLeft08Original,
                Sprite01MainRight01Original,Sprite01MainRight02Original, Sprite01MainRight03Original, Sprite01MainRight04Original,
                Sprite01MainRight05Original, Sprite01MainRight06Original, Sprite01MainRight07Original, Sprite01MainRight08Original,
                Sprite01Stack01Original, Sprite01Stack02Original, Sprite01Stack03Original, Sprite01Stack04Original, Sprite01Stack05Original,
                Sprite01Stack06Original, Sprite01Stack07Original, Sprite01Stack08Original, Sprite01Stack09Original, Sprite01Stack10Original,
                Sprite01Bottom01Original, Sprite01Bottom02Original, Sprite01Bottom03Original, Sprite01Bottom04Original
            };

            for (int i = 0; i < _frames; i++)
            {
                foreach (Rectangle rect in originals)
                {
                    Rectangle add = rect;
                    add.X = rect.X + (i * 50 * _width);
                    output.Add(add);
                }
            }

            return output;
        }

        public static List<Rectangle> Solved()
        {
            List<Rectangle> output = new List<Rectangle>();
            List<Rectangle> solved = new List<Rectangle>
            {
                Sprite01MainLeft01Solved, Sprite01MainLeft02Solved, Sprite01MainLeft03Solved, Sprite01MainLeft04Solved,
                Sprite01MainLeft05Solved, Sprite01MainLeft06Solved, Sprite01MainLeft07Solved, Sprite01MainLeft08Solved,
                Sprite01MainRight01Solved,Sprite01MainRight02Solved, Sprite01MainRight03Solved, Sprite01MainRight04Solved,
                Sprite01MainRight05Solved, Sprite01MainRight06Solved, Sprite01MainRight07Solved, Sprite01MainRight08Solved,
                Sprite01Stack01Solved, Sprite01Stack02Solved, Sprite01Stack03Solved, Sprite01Stack04Solved, Sprite01Stack05Solved,
                Sprite01Stack06Solved, Sprite01Stack07Solved, Sprite01Stack08Solved, Sprite01Stack09Solved, Sprite01Stack10Solved,
                Sprite01Bottom01Solved, Sprite01Bottom02Solved, Sprite01Bottom03Solved, Sprite01Bottom04Solved
            };

            for (int i = 0; i < _frames; i++)
            {
                foreach (Rectangle rect in solved)
                {
                    Rectangle add = rect;
                    add.X = rect.X + (i * 5 * _width) + (i * 4);
                    output.Add(add);
                }
            }

            return output;
        }
    }
}
