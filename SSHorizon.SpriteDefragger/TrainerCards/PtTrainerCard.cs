using System.Collections.Generic;
using System.Drawing;

namespace SSHorizon.SpriteDefragger.TrainerCards
{
    public class PtTrainerCard
    {
        private static readonly Rectangle MALE_HEAD_TOP_ORIG = new Rectangle(8, 0, 16, 8);
        private static readonly Rectangle MALE_HAT_ORIG = new Rectangle(32, 0, 24, 8);
        private static readonly Rectangle MALE_FACE_ORIG = new Rectangle(80, 0, 24, 8);
        private static readonly Rectangle MALE_CHEST_ORIG = new Rectangle(136, 0, 32, 8);
        private static readonly Rectangle MALE_LEFT_ORIG = new Rectangle(200, 0, 18, 8);
        private static readonly Rectangle MALE_RIGHT_ORIG = new Rectangle(218, 0, 22, 8);
        private static readonly Rectangle MALE_WAIST_ORIG = new Rectangle(272, 0, 40, 8);
        private static readonly Rectangle MALE_CROTCH_ORIG = new Rectangle(336, 0, 32, 8);
        private static readonly Rectangle MALE_KNEES_ORIG = new Rectangle(384, 0, 32, 8);
        private static readonly Rectangle MALE_FEET_ORIG = new Rectangle(448, 0, 40, 8);
        private static readonly Rectangle MALE_BOTTOM_ORIG = new Rectangle(512, 0, 8, 8);

        private static readonly Rectangle MALE_HEAD_TOP_SOLVED = new Rectangle(12, 0, 16, 8);
        private static readonly Rectangle MALE_HAT_SOLVED = new Rectangle(4, 8, 24, 8);
        private static readonly Rectangle MALE_FACE_SOLVED = new Rectangle(4, 16, 24, 8);
        private static readonly Rectangle MALE_CHEST_SOLVED = new Rectangle(4, 24, 32, 8);
        private static readonly Rectangle MALE_LEFT_SOLVED = new Rectangle(4, 32, 18, 8);
        private static readonly Rectangle MALE_RIGHT_SOLVED = new Rectangle(22, 32, 22, 8);
        private static readonly Rectangle MALE_WAIST_SOLVED = new Rectangle(4, 40, 40, 8);
        private static readonly Rectangle MALE_CROTCH_SOLVED = new Rectangle(4, 48, 32, 8);
        private static readonly Rectangle MALE_KNEES_SOLVED = new Rectangle(4, 56, 32, 8);
        private static readonly Rectangle MALE_FEET_SOLVED = new Rectangle(4, 64, 40, 8);
        private static readonly Rectangle MALE_BOTTOM_SOLVED = new Rectangle(4, 72, 8, 8);

        private static readonly Rectangle FEMALE_HEAD_TOP_ORIG = new Rectangle(24, 0, 8, 8);
        private static readonly Rectangle FEMALE_HAT_ORIG = new Rectangle(56, 0, 24, 8);
        private static readonly Rectangle FEMALE_FACE_ORIG = new Rectangle(104, 0, 32, 8);
        private static readonly Rectangle FEMALE_CHEST_ORIG = new Rectangle(168, 0, 32, 8);
        private static readonly Rectangle FEMALE_LEFT_ORIG = new Rectangle(240, 0, 16, 8);
        private static readonly Rectangle FEMALE_RIGHT_ORIG = new Rectangle(256, 0, 16, 8);
        private static readonly Rectangle FEMALE_WAIST_ORIG = new Rectangle(312, 0, 24, 8);
        private static readonly Rectangle FEMALE_CROTCH_ORIG = new Rectangle(368, 0, 16, 8);
        private static readonly Rectangle FEMALE_KNEES_ORIG = new Rectangle(416, 0, 32, 8);
        private static readonly Rectangle FEMALE_FEET_ORIG = new Rectangle(488, 0, 24, 8);
        private static readonly Rectangle FEMALE_BOTTOM_ORIG = new Rectangle(520, 0, 8, 8);


        private static readonly Rectangle FEMALE_HEAD_TOP_SOLVED = new Rectangle(80, 0, 8, 8);
        private static readonly Rectangle FEMALE_HAT_SOLVED = new Rectangle(72, 8, 24, 8);
        private static readonly Rectangle FEMALE_FACE_SOLVED = new Rectangle(64, 16, 32, 8);
        private static readonly Rectangle FEMALE_CHEST_SOLVED = new Rectangle(64, 24, 32, 8);
        private static readonly Rectangle FEMALE_LEFT_SOLVED = new Rectangle(64, 32, 16, 8);
        private static readonly Rectangle FEMALE_RIGHT_SOLVED = new Rectangle(80, 32, 16, 8);
        private static readonly Rectangle FEMALE_WAIST_SOLVED = new Rectangle(64, 40, 24, 8);
        private static readonly Rectangle FEMALE_CROTCH_SOLVED = new Rectangle(72, 48, 16, 8);
        private static readonly Rectangle FEMALE_KNEES_SOLVED = new Rectangle(64, 56, 32, 8);
        private static readonly Rectangle FEMALE_FEET_SOLVED = new Rectangle(72, 64, 24, 8);
        private static readonly Rectangle FEMALE_BOTTOM_SOLVED = new Rectangle(72, 72, 8, 8);


        public static List<Rectangle> Originals()
        {
            return new List<Rectangle>
            {
                MALE_HEAD_TOP_ORIG, MALE_HAT_ORIG, MALE_FACE_ORIG, MALE_CHEST_ORIG, MALE_WAIST_ORIG, MALE_CROTCH_ORIG, MALE_KNEES_ORIG, MALE_FEET_ORIG, MALE_BOTTOM_ORIG,
                FEMALE_HEAD_TOP_ORIG, FEMALE_HAT_ORIG, FEMALE_FACE_ORIG, FEMALE_CHEST_ORIG, FEMALE_WAIST_ORIG, FEMALE_CROTCH_ORIG, FEMALE_KNEES_ORIG, FEMALE_FEET_ORIG, FEMALE_BOTTOM_ORIG,
                MALE_LEFT_ORIG, MALE_RIGHT_ORIG, FEMALE_LEFT_ORIG, FEMALE_RIGHT_ORIG
            };
        }

        public static List<Rectangle> Solved()
        {
            return new List<Rectangle>
            {
                MALE_HEAD_TOP_SOLVED, MALE_HAT_SOLVED, MALE_FACE_SOLVED, MALE_CHEST_SOLVED, MALE_WAIST_SOLVED, MALE_CROTCH_SOLVED, MALE_KNEES_SOLVED, MALE_FEET_SOLVED, MALE_BOTTOM_SOLVED,
                FEMALE_HEAD_TOP_SOLVED, FEMALE_HAT_SOLVED, FEMALE_FACE_SOLVED, FEMALE_CHEST_SOLVED, FEMALE_WAIST_SOLVED, FEMALE_CROTCH_SOLVED, FEMALE_KNEES_SOLVED, FEMALE_FEET_SOLVED, FEMALE_BOTTOM_SOLVED,
                MALE_LEFT_SOLVED, MALE_RIGHT_SOLVED, FEMALE_LEFT_SOLVED, FEMALE_RIGHT_SOLVED
            };
        }
    }
}
