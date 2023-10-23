using Api.Services;
using Built_in_ASP_IoC_Container;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Controller
{
    [Produces("application/json")]
    [Route("api/Cards")]
    public class CardController : ControllerBase
    {

        private ICardsService _cardsService;

        public CardController(ICardsService cardsService)
        {
            _cardsService = cardsService;
        }

        [HttpGet("")]
        public IEnumerable<Card> GetAll()
        {
            return _cardsService.FetchCards();
        }

    }
}
