using System.Drawing;

namespace EliteDangerousCrosshair2
{
    public class WindowLocation
    {
        public Point TopPoint;
        public GameMonitor.RECT Rect;

        public bool Equals(WindowLocation o)
        {
            if (!TopPoint.Equals(o.TopPoint)) return false;
            if (!Rect.Equals(o.Rect)) return false;
            return true;
        }
    }
}
