using VillaApi.data;
using VillaApi.models;
using VillaApi.Repository.IRepository;

namespace VillaApi.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaNumberRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedAt = DateTime.Now;
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
