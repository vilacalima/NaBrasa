using NaBrasa_Service.Model;

namespace NaBrasa_Service.Interfaces
{
    public interface IHamburguerDAO<H> where H : HamburguerMenu
    {
        Task<H> GetHamburguerById(int id);
        Task<H> InsertHamburguer(H hamburguer);
        Task<H> UpdateHamburguer(H hamburguer);
        Task DeleteHamburguer(int id);
        Task<List<HamburguerMenu>> GetListHamburguer();
    }
}
