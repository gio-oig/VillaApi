using VillaApi.models.Dto;

namespace VillaApi.data
{
    public static class VillaStore
    {
        public static List<VillaDTO> vilaList = new List<VillaDTO>
        {
             new VillaDTO{Id=1, Name="Pool View", Sqft=100,Occupancy = 4},
             new VillaDTO{Id=2, Name="Beach View", Sqft=300,Occupancy = 3},
        };
    }
}
