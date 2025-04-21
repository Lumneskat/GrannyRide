namespace GrannyRide;

public class Lists
{
   public List<RoadMarkings> listRoadMarkings = new List<RoadMarkings>();

   public void AddRoadMarkings(RoadMarkings markings)
   {
      listRoadMarkings.Add(markings);
   }

   public void RemoveRoadMarkings(RoadMarkings markings)
   {
      listRoadMarkings.Remove(markings);
   }
   
   //
   public List<Granny> listGranny = new List<Granny>();
   
   public void AddGranny(Granny granny)
   {
      listGranny.Add(granny);
   }

   public void RemoveGranny(Granny granny)
   {
      listGranny.Remove(granny);
   }
}