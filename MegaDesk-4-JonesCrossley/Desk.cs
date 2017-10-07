
namespace MegaDesk_4_JonesCrossley
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int DrawerCount { get; set; }
        public DesktopMaterial Surface { get; set; }

        public enum DesktopMaterial {
            Laminate = 100, Oak = 200, Rosewood = 300, Veneer = 125, Pine = 50};

        public int GetSurfaceArea()
        {
            int area;
            area = Width * Depth;
            return area;
        }
    }
}
