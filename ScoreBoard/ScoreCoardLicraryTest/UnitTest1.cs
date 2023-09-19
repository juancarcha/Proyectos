namespace ScoreCoardLicraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Test_StartGame()
    {
        var scoreBoard = new ScoreBoardClassLibrary();
        string homeTeam = "Spain";
        string awayTeam = "Malta";

        scoreBoard.StartGame (homeTeam, awayTeam);

        Assert.AreEqual(1, scoreBoard.GetSumary().Count);
    }

    [TestMethod]
    public void Test_FinishGame()
    {
        var scoreBoard = new ScoreBoardClassLibrary();
        string homeTeam = "Spain";
        string awayTeam = "Malta";

        scoreBoard.StartGame (homeTeam, awayTeam);
        scoreBoard.FinishGame (homeTeam, awayTeam);

        Assert.AreEqual(1, scoreBoard.GetSumary().Count);
    }

    [TestMethod]
    public void Test_UpdateScore()
    {
        var scoreBoard = new ScoreBoardClassLibrary();
        string homeTeam = "Spain";
        string awayTeam = "Malta";

        scoreBoard.StartGame (homeTeam, awayTeam);
        scoreBoard.UpdateScore (12, 1, homeTeam, awayTeam);

        var sumary = scoreBoard.GetSumary();

        Assert.AreEqual("Spain 12 - Malta 1", sumary[0]);
    }

    [TestMethod]
    public void Test_GetSumary()
    {
        var scoreBoard = new ScoreBoardClassLibrary();

        scoreBoard.StartGame ("Spain", "Malta");
        scoreBoard.StartGame ("Sevilla", "Betis");
        scoreBoard.StartGame ("Athletic", "Real Sociedad");
        scoreBoard.StartGame ("Deportivo", "Celta");

        var sumary = scoreBoard.GetSumary();

        Assert.AreEqual("Deportivo 0 - Celta 0", sumary[0]);
        Assert.AreEqual("Athletic 0 - Real Sociedad 0", sumary[1]);
        Assert.AreEqual("Sevilla 0 - Betis 0", sumary[2]);
        Assert.AreEqual("Spain 0 - Malta 0", sumary[3]);
    }


}