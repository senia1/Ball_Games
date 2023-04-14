
namespace SalutWinFormsApp
{
    public class HitEventArgs
    {
        public float X;
        public float Y;
        public HitEventArgs(float centerX, float centerY)
        {
            X = centerX;
            Y = centerY;
        }
    }
}
