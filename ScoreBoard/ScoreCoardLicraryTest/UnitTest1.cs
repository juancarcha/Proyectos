using ScoreBoard;

namespace ScoreCoardLicraryTest;

[TestClass]
public class UnitTest1
{
    private const string homeTeam = "Spain";
    private const string awayTeam = "Malta";

    [TestMethod]
    public void Test_StartGame()
    {
        var scoreBoard = new MatchScoreBoard();

        scoreBoard.StartGame (homeTeam, awayTeam);

        Assert.AreEqual(1, scoreBoard.GetSummary().Count);
    }

    [TestMethod]
    public void Test_FinishGame()
    {
        var scoreBoard = new MatchScoreBoard();

        scoreBoard.StartGame (homeTeam, awayTeam);
        scoreBoard.FinishGame (homeTeam, awayTeam);

        Assert.AreEqual(0, scoreBoard.GetSummary().Count);
    }

    [TestMethod]
    public void Test_UpdateScore()
    {
        var scoreBoard = new MatchScoreBoard();

        scoreBoard.StartGame (homeTeam, awayTeam);
        scoreBoard.UpdateScoreBoard (12, 1, homeTeam, awayTeam);

        var sumary = scoreBoard.GetSummary();

        Assert.AreEqual("Spain 12 - Malta 1", sumary[0]);
    }

    [TestMethod]
    public void Test_GetSumary()
    {
        var scoreBoard = new MatchScoreBoard();

        scoreBoard.StartGame (homeTeam, awayTeam);
        scoreBoard.StartGame ("Sevilla", "Betis");
        scoreBoard.StartGame ("Athletic", "Real Sociedad");
        scoreBoard.StartGame ("Deportivo", "Celta");
        scoreBoard.UpdateScoreBoard (12, 1, homeTeam, awayTeam);
        scoreBoard.UpdateScoreBoard (5, 1, "Sevilla", "Betis");

        var sumary = scoreBoard.GetSummary();

        Assert.AreEqual("Spain 12 - Malta 1", sumary[0]);
        Assert.AreEqual("Sevilla 5 - Betis 1", sumary[1]);
        Assert.AreEqual("Deportivo 0 - Celta 0", sumary[2]);
        Assert.AreEqual("Athletic 0 - Real Sociedad 0", sumary[3]);
        
    }


}