namespace MarvelApp.Ex2.CQRS.Models.Query
{
    public class GetWinnerQuery : IQuery
    {
        public string Superhero { get; set; }
        public string Villain { get; set; }
        public int BattlegroundId { get; set; }

        public GetWinnerQuery(string superhero, string villain, int battlegroundId)
        {
            Superhero = superhero;
            Villain = villain;
            BattlegroundId = battlegroundId;
        }
    }
}