using HumansApis.Models.Domain;
using HumansApis.Models.DTO;

namespace HumansApis.Repositories
{
    public interface IHumansRepository
    {
        Task<IEnumerable<humans>> GetAll();

        Task<humans> GetHumanById(Guid id);

        Task<humans> AddHuman(humans human);

        Task<humans> UpdateHuman(humans human);


    }
}
