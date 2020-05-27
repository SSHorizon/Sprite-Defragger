using System.Collections.Generic;
using System.Drawing;

namespace SSHorizon.SpriteDefragger.TrainerCards
{
    public class DpTrainerCard
    {
        private static readonly Rectangle MALE_HEAD_TOP_ORIG = new Rectangle(7, 0, 8, 8);
        private static readonly Rectangle MALE_HAT_ORIG = new Rectangle(23, 0, 24, 8);
        private static readonly Rectangle MALE_FACE_ORIG = new Rectangle(79, 0, 40, 8);
        private static readonly Rectangle MALE_CHEST_ORIG = new Rectangle(151, 0, 40, 8);
        private static readonly Rectangle MALE_WAIST_ORIG = new Rectangle(223, 0, 32, 8);
        private static readonly Rectangle MALE_CROTCH_ORIG = new Rectangle(303, 0, 24, 8);
        private static readonly Rectangle MALE_KNEES_ORIG = new Rectangle(367, 0, 32, 8);
        private static readonly Rectangle MALE_LEGS_ORIG = new Rectangle(424, 0, 32, 8);
        private static readonly Rectangle MALE_FEET_ORIG = new Rectangle(487, 0, 32, 8);
        private static readonly Rectangle MALE_BOTTOM_ORIG = new Rectangle(551, 0, 8, 8);

        private static readonly Rectangle MALE_HEAD_TOP_SOLVED = new Rectangle(28, 0, 8, 8);
        private static readonly Rectangle MALE_HAT_SOLVED = new Rectangle(20, 8, 24, 8);
        private static readonly Rectangle MALE_FACE_SOLVED = new Rectangle(4, 16, 40, 8);
        private static readonly Rectangle MALE_CHEST_SOLVED = new Rectangle(4, 24, 40, 8);
        private static readonly Rectangle MALE_WAIST_SOLVED = new Rectangle(12, 32, 32, 8);
        private static readonly Rectangle MALE_CROTCH_SOLVED = new Rectangle(20, 40, 24, 8);
        private static readonly Rectangle MALE_KNEES_SOLVED = new Rectangle(12, 48, 32, 8);
        private static readonly Rectangle MALE_LEGS_SOLVED = new Rectangle(12, 56, 32, 8);
        private static readonly Rectangle MALE_FEET_SOLVED = new Rectangle(12, 64, 32, 8);
        private static readonly Rectangle MALE_BOTTOM_SOLVED = new Rectangle(36, 72, 8, 8);

        private static readonly Rectangle FEMALE_HEAD_TOP_ORIG = new Rectangle(15, 0, 8, 8);
        private static readonly Rectangle FEMALE_HAT_ORIG = new Rectangle(47, 0, 32, 8);
        private static readonly Rectangle FEMALE_FACE_ORIG = new Rectangle(119, 0, 32, 8);
        private static readonly Rectangle FEMALE_CHEST_ORIG = new Rectangle(191, 0, 32, 8);
        private static readonly Rectangle FEMALE_WAIST_ORIG = new Rectangle(255, 0, 48, 8);
        private static readonly Rectangle FEMALE_CROTCH_ORIG = new Rectangle(327, 0, 40, 8);
        private static readonly Rectangle FEMALE_KNEES_ORIG = new Rectangle(400, 0, 24, 8);
        private static readonly Rectangle FEMALE_LEGS_ORIG = new Rectangle(455, 0, 32, 8);
        private static readonly Rectangle FEMALE_FEET_ORIG = new Rectangle(519, 0, 32, 8);
        private static readonly Rectangle FEMALE_BOTTOM_ORIG = new Rectangle(559, 0, 8, 8);


        private static readonly Rectangle FEMALE_HEAD_TOP_SOLVED = new Rectangle(72, 0, 8, 8);
        private static readonly Rectangle FEMALE_HAT_SOLVED = new Rectangle(56, 8, 32, 8);
        private static readonly Rectangle FEMALE_FACE_SOLVED = new Rectangle(56, 16, 32, 8);
        private static readonly Rectangle FEMALE_CHEST_SOLVED = new Rectangle(56, 24, 32, 8);
        private static readonly Rectangle FEMALE_WAIST_SOLVED = new Rectangle(48, 32, 48, 8);
        private static readonly Rectangle FEMALE_CROTCH_SOLVED = new Rectangle(56, 40, 40, 8);
        private static readonly Rectangle FEMALE_KNEES_SOLVED = new Rectangle(56, 48, 24, 8);
        private static readonly Rectangle FEMALE_LEGS_SOLVED = new Rectangle(56, 56, 32, 8);
        private static readonly Rectangle FEMALE_FEET_SOLVED = new Rectangle(56, 64, 32, 8);
        private static readonly Rectangle FEMALE_BOTTOM_SOLVED = new Rectangle(56, 72, 8, 8);

        public static List<Rectangle> Originals()
        {
            return new List<Rectangle>
            {
                MALE_HEAD_TOP_ORIG, MALE_HAT_ORIG, MALE_FACE_ORIG, MALE_CHEST_ORIG, MALE_WAIST_ORIG, MALE_CROTCH_ORIG, MALE_KNEES_ORIG, MALE_LEGS_ORIG, MALE_FEET_ORIG, MALE_BOTTOM_ORIG,
                FEMALE_HEAD_TOP_ORIG, FEMALE_HAT_ORIG, FEMALE_FACE_ORIG, FEMALE_CHEST_ORIG, FEMALE_WAIST_ORIG, FEMALE_CROTCH_ORIG, FEMALE_KNEES_ORIG, FEMALE_LEGS_ORIG, FEMALE_FEET_ORIG, FEMALE_BOTTOM_ORIG
            };
        }

        public static List<Rectangle> Solved()
        {
            return new List<Rectangle>
            {
                MALE_HEAD_TOP_SOLVED, MALE_HAT_SOLVED, MALE_FACE_SOLVED, MALE_CHEST_SOLVED, MALE_WAIST_SOLVED, MALE_CROTCH_SOLVED, MALE_KNEES_SOLVED, MALE_LEGS_SOLVED, MALE_FEET_SOLVED, MALE_BOTTOM_SOLVED,
                FEMALE_HEAD_TOP_SOLVED, FEMALE_HAT_SOLVED, FEMALE_FACE_SOLVED, FEMALE_CHEST_SOLVED, FEMALE_WAIST_SOLVED, FEMALE_CROTCH_SOLVED, FEMALE_KNEES_SOLVED, FEMALE_LEGS_SOLVED, FEMALE_FEET_SOLVED, FEMALE_BOTTOM_SOLVED
            };
        }
    }
}
