using Raylib_cs;
namespace GrannyRide;

public class Granny
{
    public int grannyPosX { get; set; }
    public int grannyPosY { get; set; }
    public int grannySpeedX { get; set; }
    public int grannySpeedY { get; set; }
    
    private Texture2D grannyTexture;
    public int grannyWidth { get; private set; }
    public int grannyHeight { get; private set; }
    
    public Granny()
    {
        Screen screen = new Screen();
        Random random = new Random();
        
        grannyTexture = Raylib.LoadTexture("/Users/andrey/RiderProjects/GrannyRide/GrannyRide/Sprite-0001.png");

        grannyWidth = grannyTexture.Width;
        grannyHeight = grannyTexture.Height;

        grannyPosX = random.Next(0,screen.screenWidth - grannyWidth);
        grannyPosY = 0 - grannyWidth;
        grannySpeedX = 1;
        grannySpeedY = 1;
    }

    public Texture2D GetGrannyTexture()
    {
        return grannyTexture;
    }
}