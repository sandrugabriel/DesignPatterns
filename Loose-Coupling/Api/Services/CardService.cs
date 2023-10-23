using Built_in_ASP_IoC_Container;

namespace Api.Services
{
    public class CardService : ICardsService
    {
        public IEnumerable<Card> FetchCards()
        {
            return new List<Card>()
            {
                new Card() {Attack1 =90,Defense1=70,Name1="Ultimate Shadow Wraith"},
                new Card() {Attack1 = 60, Defense1 = 60,Name1="a"},
                new Card() {Attack1 = 30, Defense1 = 50,Name1="b"},
                new Card() {Attack1 = 50, Defense1 = 40, Name1 = "c"},
                new Card() {Attack1 = 70, Defense1 = 30, Name1 = "d"},
                new Card() {Attack1 = 90, Defense1 = 20, Name1 = "f"},
                new Card() {Attack1 = 100, Defense1 = 10, Name1 = "h"},

            };
        }
    }
}
