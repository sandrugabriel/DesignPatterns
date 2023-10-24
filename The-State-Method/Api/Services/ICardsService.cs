using Built_in_ASP_IoC_Container;

namespace Api.Services
{
    public interface ICardsService
    {
        IEnumerable<Card> FetchCards();
    }
}
