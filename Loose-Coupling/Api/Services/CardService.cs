using Built_in_ASP_IoC_Container;

namespace Api.Services
{
    public class CardService : ICardsService
    {
        public IEnumerable<Card> FetchCards()
        {
            return new List<Card>()
            {
                new Card() {Attack =90,Defense=70,Name="Ultimate Shadow Wraith"},
                new Card() {Attack =60,Defense=60,Name="a"},
                new Card() {Attack =30,Defense=50,Name="b"},
                new Card() {Attack =50,Defense=40,Name="c"},
                new Card() {Attack =70,Defense=30,Name="d"},
                new Card() {Attack =90,Defense=20,Name="f"},
                new Card() {Attack =100,Defense=10,Name="h"},

            };
        }
    }
}
