using Raylib_cs;
namespace GrannyRide;

public class Render
{
    public void PlayerRender(Player player)
    {
        Raylib.DrawTexture(player.GetPlayerTexture(),player.playerPosX,player.playerPosY, Color.White);
    }

    public void RoadMarkingsListRender(Lists lists)
    {
        RoadMarkings markings = new RoadMarkings();
        foreach (var mark in lists.listRoadMarkings)
        {
            Raylib.DrawRectangle(mark.roadMarkingsPosX, mark.roadMarkingsPosY, mark.roadMarkingsWidth, mark.roadMarkingsHeight, mark.roadMarkingsColor);
        }
    }

    public void GrannyListRender(Lists lists)
    {
        Granny granny = new Granny();
        foreach (var gran in lists.listGranny)
        {
            Raylib.DrawTexture(gran.GetGrannyTexture(),gran.grannyPosX, gran.grannyPosY, Color.White);
        }
    }
}