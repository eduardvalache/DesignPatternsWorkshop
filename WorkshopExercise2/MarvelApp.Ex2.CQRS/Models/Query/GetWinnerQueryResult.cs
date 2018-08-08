namespace MarvelApp.Ex2.CQRS.Models.Query
{
    public class GetWinnerQueryResult : IQueryResult
    {
        public GetWinnerQueryResult(string winner)
        {
            Winner = winner;
        }

        public string Winner { get; set; }
    }
}