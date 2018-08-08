namespace MarvelApp.Ex2.CQRS.Models.Command
{
    public class AddWinnerCommand : ICommand
    {
        public string WinnerAlias { get; set; }

        public AddWinnerCommand(string winnerAlias)
        {
            WinnerAlias = winnerAlias;
        }
    }
}