
namespace ScoreBoard;

public class MatchScoreBoard
{
    private List<Match> matches = new List<Match>();

    public void StartGame(String homeTeam, string awayTeam)
    {
        var match = new Match (homeTeam, awayTeam);
        matches.Add(match);
    }

    public void FinishGame (string homeTeam, string awayTeam)
    {
        var matchToDelete = matches.FirstOrDefault(m => 
        m.HomeTeam.Equals(homeTeam, StringComparison.OrdinalIgnoreCase) && 
        m.AwayTeam.Equals(awayTeam, StringComparison.OrdinalIgnoreCase));

        if(matchToDelete != null)
            matches.Remove(matchToDelete);
    }

    public void UpdateScoreBoard (int homeScore, int awayScore, string homeTeam, string awayTeam)
    {
        var matchToUpdate = matches.FirstOrDefault(m => 
        m.HomeTeam.Equals(homeTeam, StringComparison.OrdinalIgnoreCase) && 
        m.AwayTeam.Equals(awayTeam, StringComparison.OrdinalIgnoreCase));

        matchToUpdate?.UpdateScoreBoard (homeScore, awayScore);
    }

    public List<String> GetSummary()
    {
        var matches = this.matches.OrderByDescending(m => m.HomeScore + m.AwayScore).ThenByDescending(m => this.matches.IndexOf(m)).Select(m => m.GetSumary()).ToList();

        return matches;
    }

}
