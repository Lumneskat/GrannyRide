using Raylib_cs;

namespace GrannyRide;

public class Player
{
    public int playerPosX { get; set; }
    public int playerPosY { get; set; }
    public int playerSpeedX { get; set; }
    public int playerSpeedY { get; set; }
    
    private Texture2D playerTexture;
    public int playerWidth { get; private set; }
    public int playerHeight { get; private set; }
    
    public Player()
    {
        playerTexture = Raylib.LoadTexture("/Users/andrey/RiderProjects/GrannyRide/GrannyRide/Sprite-0002.png");

        playerWidth = playerTexture.Width;
        playerHeight = playerTexture.Height;

        playerPosX = 180;
        playerPosY = 400;
        playerSpeedX = 2;
        playerSpeedY = 2;
    }

    public Texture2D GetPlayerTexture()
    {
        return playerTexture;
    }

    public void PlayerMove(Player player)
    {
        if (Raylib.IsKeyDown(KeyboardKey.A)) player.playerPosX -= playerSpeedX;
        if (Raylib.IsKeyDown(KeyboardKey.D)) player.playerPosX += playerSpeedX;
        if (Raylib.IsKeyDown(KeyboardKey.W)) player.playerPosY -= playerSpeedY;
        if (Raylib.IsKeyDown(KeyboardKey.S)) player.playerPosY += playerSpeedY;
    }

    public void PlayerTuchScreen(Player player, Screen screen)
    {
        if (player.playerPosX <= 0) player.playerPosX = 0;
        if (player.playerPosX >= screen.screenWidth - player.playerWidth) player.playerPosX = screen.screenWidth - player.playerWidth;
        if (player.playerPosY <= 0) player.playerPosY = 0;
        if (player.playerPosY + player.playerHeight >= screen.screenHeight) player.playerPosY = screen.screenHeight - player.playerHeight;
        
    }

    public bool PlayerTuchGranny(Player player, Lists lists)
    {
        for (int i = lists.listGranny.Count - 1; i >= 0; i--)
        {
            var granny = lists.listGranny[i]; //1 вариант
            
            int x1 = player.playerPosX; 
            int y1 = player.playerPosY;
            int w1 = player.playerWidth;
            int h1 = player.playerHeight;

            int x2 = lists.listGranny[i].grannyPosX; //2 вариант
            int y2 = granny.grannyPosY;
            int w2 = granny.grannyWidth;
            int h2 = granny.grannyHeight;

            if (x1 < x2 + w2 &&
                x1 + w1 > x2 &&
                y1 < y2 + h2 &&
                y1 + h1 > y2)
            {
                return true;
            }
        }
        return false;
    }
}