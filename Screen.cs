using Raylib_cs;
namespace GrannyRide;

public class Screen
{
    public int screenWidth { get; }
    public int screenHeight { get; }

    public Screen()
    {
        screenWidth = 400;
        screenHeight = 500;
    }
    public void ScreenConstructor()
    {
        Raylib.InitWindow(screenWidth, screenHeight, "Granny Ride");
        Raylib.SetTargetFPS(60);
    }
}