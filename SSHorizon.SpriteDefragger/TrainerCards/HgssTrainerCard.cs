using System.Collections.Generic;
using System.Drawing;

namespace SSHorizon.SpriteDefragger.TrainerCards
{
    public class HgssTrainerCard
    {
        private static readonly Rectangle MALE_HEAD_TOP_ORIG = new Rectangle(136, 0, 40, 8);
        private static readonly Rectangle MALE_HAT_ORIG = new Rectangle(392, 0, 40, 8);
        private static readonly Rectangle MALE_FACE_ORIG = new Rectangle(648, 0, 40, 8);
        private static readonly Rectangle MALE_CHEST_ORIG = new Rectangle(904, 0, 40, 8);
        private static readonly Rectangle MALE_WAIST_ORIG = new Rectangle(184, 0, 40, 8);
        private static readonly Rectangle MALE_CROTCH_ORIG = new Rectangle(440, 0, 40, 8);
        private static readonly Rectangle MALE_KNEES_ORIG = new Rectangle(696, 0, 40, 8);
        private static readonly Rectangle MALE_FEET_ORIG = new Rectangle(952, 0, 40, 8);
        private static readonly Rectangle MALE_BOTTOM_ORIG = new Rectangle(856, 0, 40, 8);

        private static readonly Rectangle MALE_HEAD_TOP_SOLVED = new Rectangle(4, 4, 40, 8);
        private static readonly Rectangle MALE_HAT_SOLVED = new Rectangle(4, 12, 40, 8);
        private static readonly Rectangle MALE_FACE_SOLVED = new Rectangle(4, 20, 40, 8);
        private static readonly Rectangle MALE_CHEST_SOLVED = new Rectangle(4, 28, 40, 8);
        private static readonly Rectangle MALE_WAIST_SOLVED = new Rectangle(4, 36, 40, 8);
        private static readonly Rectangle MALE_CROTCH_SOLVED = new Rectangle(4, 44, 40, 8);
        private static readonly Rectangle MALE_KNEES_SOLVED = new Rectangle(4, 52, 40, 8);
        private static readonly Rectangle MALE_FEET_SOLVED = new Rectangle(4, 60, 40, 8);
        private static readonly Rectangle MALE_BOTTOM_SOLVED = new Rectangle(4, 68, 40, 8);

        private static readonly Rectangle FEMALE_HEAD_TOP_ORIG = new Rectangle(8, 0, 40, 8);
        private static readonly Rectangle FEMALE_HAT_ORIG = new Rectangle(264, 0, 40, 8);
        private static readonly Rectangle FEMALE_FACE_ORIG = new Rectangle(520, 0, 40, 8);
        private static readonly Rectangle FEMALE_CHEST_ORIG = new Rectangle(776, 0, 40, 8);
        private static readonly Rectangle FEMALE_WAIST_ORIG = new Rectangle(48, 0, 40, 8);
        private static readonly Rectangle FEMALE_CROTCH_ORIG = new Rectangle(304, 0, 40, 8);
        private static readonly Rectangle FEMALE_KNEES_ORIG = new Rectangle(560, 0, 40, 8);
        private static readonly Rectangle FEMALE_FEET_ORIG = new Rectangle(816, 0, 40, 8);
        private static readonly Rectangle FEMALE_BOTTOM_ORIG = new Rectangle(88, 0, 40, 8);


        private static readonly Rectangle FEMALE_HEAD_TOP_SOLVED = new Rectangle(56, 4, 40, 8);
        private static readonly Rectangle FEMALE_HAT_SOLVED = new Rectangle(56, 12, 40, 8);
        private static readonly Rectangle FEMALE_FACE_SOLVED = new Rectangle(56, 20, 40, 8);
        private static readonly Rectangle FEMALE_CHEST_SOLVED = new Rectangle(56, 28, 40, 8);
        private static readonly Rectangle FEMALE_WAIST_SOLVED = new Rectangle(56, 36, 40, 8);
        private static readonly Rectangle FEMALE_CROTCH_SOLVED = new Rectangle(56, 44, 40, 8);
        private static readonly Rectangle FEMALE_KNEES_SOLVED = new Rectangle(56, 52, 40, 8);
        private static readonly Rectangle FEMALE_FEET_SOLVED = new Rectangle(56, 60, 40, 8);
        private static readonly Rectangle FEMALE_BOTTOM_SOLVED = new Rectangle(56, 68, 40, 8);


        public static List<Rectangle> Originals()
        {
            return new List<Rectangle>
            {
                MALE_HEAD_TOP_ORIG, MALE_HAT_ORIG, MALE_FACE_ORIG, MALE_CHEST_ORIG, MALE_WAIST_ORIG, MALE_CROTCH_ORIG, MALE_KNEES_ORIG, MALE_FEET_ORIG, MALE_BOTTOM_ORIG,
                FEMALE_HEAD_TOP_ORIG, FEMALE_HAT_ORIG, FEMALE_FACE_ORIG, FEMALE_CHEST_ORIG, FEMALE_WAIST_ORIG, FEMALE_CROTCH_ORIG, FEMALE_KNEES_ORIG, FEMALE_FEET_ORIG, FEMALE_BOTTOM_ORIG
            };
        }

        public static List<Rectangle> Solved()
        {
            return new List<Rectangle>
            {
                MALE_HEAD_TOP_SOLVED, MALE_HAT_SOLVED, MALE_FACE_SOLVED, MALE_CHEST_SOLVED, MALE_WAIST_SOLVED, MALE_CROTCH_SOLVED, MALE_KNEES_SOLVED, MALE_FEET_SOLVED, MALE_BOTTOM_SOLVED,
                FEMALE_HEAD_TOP_SOLVED, FEMALE_HAT_SOLVED, FEMALE_FACE_SOLVED, FEMALE_CHEST_SOLVED, FEMALE_WAIST_SOLVED, FEMALE_CROTCH_SOLVED, FEMALE_KNEES_SOLVED, FEMALE_FEET_SOLVED, FEMALE_BOTTOM_SOLVED
            };
        }
    }
}
