namespace Pong
{
    public class CollisionDetector
    {
        /// <summary>
        /// Calculates if rectangles describing two sprites
        /// are overlapping on screen.
        /// </summary>
        /// <param name="s1">First sprite</param>
        /// <param name="s2">Second sprite</param>
        /// <returns>Returns true if overlapping</returns>
        public static bool Overlaps(Sprite s1, Sprite s2)
        {
            float x1 = s1.Position.X;
            float y1 = s1.Position.Y;
            float h1 = s1.Size.Height;
            float w1 = s1.Size.Width;
            float x2 = s2.Position.X;
            float y2 = s2.Position.Y;
            float h2 = s2.Size.Height;
            float w2 = s2.Size.Width;
            if (x1 < x2 + w2 &&
                x1 + w1 > x2 &&
                y1 < y2 + h2 &&
                h1 + y1 > y2)
                return true;


                return false;
        }
    }
}