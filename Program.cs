using Raylib_cs;
namespace GrannyRide;

class Program
{
    static void Main(string[] args)
    {
        Screen screen = new Screen();
        screen.ScreenConstructor();
        Player player = new Player();
        Render render = new Render();
        Lists lists = new Lists();
        int fpsCounter = 0;
        bool GameOver = false;

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            
            // Очистка экрана перед каждой отрисовкой
            Raylib.ClearBackground(Color.Black);

            if (!GameOver)
            {
                fpsCounter += 1;

                player.PlayerMove(player);
                player.PlayerTuchScreen(player, screen);

                if (fpsCounter == 30)
                {
                    RoadMarkings markings = new RoadMarkings();
                    lists.AddRoadMarkings(markings);

                    Granny granny = new Granny();
                    lists.AddGranny(granny);

                    fpsCounter = 0;
                }

                render.RoadMarkingsListRender(lists);
                render.GrannyListRender(lists);

                foreach (var mark in lists.listRoadMarkings)
                {
                    mark.roadMarkingsPosY = mark.roadMarkingsPosY + mark.RoadMarkingsSpeed;
                }

                foreach (var gran in lists.listGranny)
                {
                    Random random = new Random();

                    gran.grannyPosY = gran.grannyPosY + random.Next(-3, 10);
                    gran.grannyPosX = gran.grannyPosX + random.Next(-10, 10);
                }

                for (int i = lists.listRoadMarkings.Count - 1; i >= 0; i--)
                {
                    if (lists.listRoadMarkings[i].roadMarkingsPosY >= screen.screenHeight)
                    {
                        lists.listRoadMarkings.RemoveAt(i);
                    }
                }

                for (int i = lists.listGranny.Count - 1; i >= 0; i--)
                {
                    if (lists.listGranny[i].grannyPosX > screen.screenWidth || lists.listGranny[i].grannyPosX < -50)
                    {
                        lists.listGranny.RemoveAt(i);
                    }
                    else if (lists.listGranny[i].grannyPosY > screen.screenHeight ||
                             lists.listGranny[i].grannyPosY < -50)
                    {
                        lists.listGranny.RemoveAt(i);
                    }
                }

                if (player.PlayerTuchGranny(player, lists) == true)
                {
                    GameOver = true;
                }

                render.PlayerRender(player);
            }

            if (GameOver)
            {
                string gameOverText = "GAME OVER";
                int fontSize = 60;
                int textWidth = Raylib.MeasureText(gameOverText, fontSize);
                int posX = (screen.screenWidth - textWidth) / 2;
                int posY = screen.screenHeight / 2 - fontSize / 2;

                Raylib.DrawText(gameOverText, posX, posY, fontSize, Color.Red);
            }

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
