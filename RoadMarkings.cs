using Raylib_cs;
namespace GrannyRide;

public class RoadMarkings
{
    public int roadMarkingsPosX { get; set; }
    public int roadMarkingsPosY { get; set; }
    public int roadMarkingsWidth { get; set; }
    public int roadMarkingsHeight { get; set; }
    public Color roadMarkingsColor { get; set; }
    
    public int RoadMarkingsSpeed { get; set; }

    public RoadMarkings()
    {
        Screen screen = new Screen();
        
        roadMarkingsPosX = screen.screenWidth / 2 - roadMarkingsWidth / 2;
        roadMarkingsPosY = 0;
        
        roadMarkingsWidth = 5;
        roadMarkingsHeight = 20;
        roadMarkingsColor = Color.Yellow;

        RoadMarkingsSpeed = 5;

    }
    
}