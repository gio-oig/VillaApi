using VillaApi.models;

namespace VillaApi.Repository.IRepository
{
    public interface IVillaNumberRepository: IRepository<VillaNumber>
    {

        Task<VillaNumber> UpdateAsync(VillaNumber villaNumber);
    }
}
