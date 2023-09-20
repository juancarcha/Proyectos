public class Match
{
    public string HomeTeam { get; set; }
    public string AwayTeam { get; set; }
    public int HomeScore { get; set; }
    public int AwayScore { get; set; }

    public Match (string homeTeam, string awayTeam)
    {
        HomeTeam = homeTeam;
        AwayTeam = awayTeam;
        HomeScore = 0;
        AwayScore = 0;
    }

    public void UpdateScoreBoard (int homeScore, int awayScore)
    {
        HomeScore = homeScore;
        AwayScore = awayScore;
    }

    public string GetSumary()
    {
        return $"{HomeTeam} {HomeScore} - {AwayTeam} {AwayScore}";
    }
}