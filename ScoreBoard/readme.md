This code has been developed using .Net 7.

The unit tests have been done using NUnit.

Project requeriments:

1. Instructions
Before anything, thanks for doing this test as a SportRadar candidate.
We know this kind of coding exercises require your time, so we really appreciate your effort and
time for doing it as best as you can.
Please, provide the implementation of the Football World Cup Score Board as a simple library.

2. Guidelines
• Keep it simple. Stick to the requirements and try to implement the simplest solution you
can possibly think of that works and don't forget about edge cases.
• Use an in-memory store solution (for example just use collections to store the
information you might require).
• We are NOT looking for a REST API, a Web Service or Microservice. Just a simple
implementation of a library.
• Focus on Code Quality. Use Test-Driven Development (TDD), pay attention to OO
design, Clean Code and adherence to good code design standards and principles
(SOLID, etc.).
• Approach. Code the solution according to your standards. Please share your solution
with a link to a source control repository (e.g. GitHub, GitLab, BitBucket) as we would
like you to see your progress (your commit history is important)
• Add a README.md file where you can make notes of any assumption or things you
would like to mention to us about your solution.
• If the implementation is in a frontend language, then it must follow all of the above
guidelines and additionally you should apply the suggestions below:
o If it is written it in a specific UI framework or library then we would suggest
writing the simplest component/s to serve the described functionality. Please
don’t spend time making it look good.
o If it is written in plain JavaScript then we would suggest implementing the
solution as a simple service or module.

3. Football World Cup Score Board requirements
You are working on a sports data company, and we would like you to develop a new Live
Football World Cup Score Board that shows matches and scores.
The board supports the following operations:
www.sportradar.com Page | 3
1. Start a game. When a game starts, it should capture (being initial score 0 – 0):
a. Home team
b. Away team
2. Finish game. It will remove a match from the scoreboard.
3. Update score. Receiving the pair score; home team score and away team score updates a
game score.
4. Get a summary of games by total score. Those games with the same total score will be
returned ordered by the most recently added to our system.
As an example, being the current data in the system:
a. Mexico - Canada: 0 - 5
b. Spain - Brazil: 10 – 2
c. Germany - France: 2 – 2
d. Uruguay - Italy: 6 – 6
e. Argentina - Australia: 3 - 1
The summary would provide with the following information:
1. Uruguay 6 - Italy 6
2. Spain 10 - Brazil 2
3. Mexico 0 - Canada 5
4. Argentina 3 - Australia 1
5. Germany 2 - France

4. Recommendations
Despite we’ve mention to keep the technical test as simple as possible, consider this:
• We use this code test to evaluate your technical coding skills.
• Do the test as best as you can with your current skills and abilities.
• The test should be simple but it must show some degree of well code design.
• Testing is important!
• Try to apply good coding practices.
• Then completed, consider if you solution is maintenable and testeable.