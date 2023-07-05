using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NaBrasa_Service.Interfaces;
using NaBrasa_Service.Model;

namespace NaBrasa_Service.Dao
{
    public class HamburguerDAO<H> : IHamburguerDAO<H> where H : HamburguerMenu
    {
        private readonly AppDBContext _context;

        public HamburguerDAO(AppDBContext dbContext)
        {
            _context = dbContext;
        }

        public async Task DeleteHamburguer(int id)
        {
            var debug = await _context.HamburguerMenus.FirstOrDefaultAsync(h => h.Id == id);
            if (debug != null)
            {
                _context.HamburguerMenus.Remove(debug);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<H> GetHamburguerById(int id)
        {
            return (H)await _context.HamburguerMenus.FirstOrDefaultAsync(h => h.Id == id);
        }

        public async Task<H> InsertHamburguer(H hamburguer)
        {
            var debug = _context.HamburguerMenus.Add(hamburguer);
            await debug.Context.SaveChangesAsync();

            return hamburguer;
        }

        public Task<H> UpdateHamburguer(H hamburguer)
        {
            throw new NotImplementedException();
        }

        public async Task<List<HamburguerMenu>> GetListHamburguer()
        {
            return await _context.HamburguerMenus.ToListAsync();
        }
    }
}
