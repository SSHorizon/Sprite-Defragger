using SSHorizon.SpriteDefragger;

namespace SSHorizon.TrainerCardSolver
{
    public class GameItem
    {
        public string Text { get; set; }
        public Game Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
