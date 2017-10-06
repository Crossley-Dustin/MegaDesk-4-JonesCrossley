
namespace MegaDesk_3_DustinCrossley
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int DrawerCount { get; set; }
        public SurfaceType Surface { get; set; }

        public enum SurfaceType{
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

        public int Area
        {
            get { return Width * Depth; }
        }
    }
}
