using HumansApis.Data;
using HumansApis.Models.Domain;
using HumansApis.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace HumansApis.Repositories
{
    public class HumansRepository : IHumansRepository
    {
        private readonly HumansContext _context;
        public HumansRepository(HumansContext context)
        {
            this._context = context;
        }
    
        public async Task<humans> AddHuman(humans human)
        {
            human.Id= Guid.NewGuid();
            await _context.AddAsync(human);
            await _context.SaveChangesAsync();
            // var newHuman = await _context.Humans.FirstOrDefaultAsync(H => H.Name == human.Name && H.Height == human.Height);
            return human;
        }

        public async Task<IEnumerable<humans>> GetAll()
        {
            return await _context.Humans.ToListAsync();

        }

        public async Task<humans> GetHumanById(Guid id)
        {
            return await _context.Humans.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<humans> UpdateHuman(humans human)
        {
            if (_context.Humans.Count(x => x.Id == human.Id) < 1)
            {
                return null;
            }
            _context.Humans.Update(human);
            await _context.SaveChangesAsync();
            return human;
        }
    }
}
