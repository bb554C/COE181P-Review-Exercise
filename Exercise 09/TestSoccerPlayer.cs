/*Create an application named TestSoccerPlayer that instantiates and displays a SoccerPlayer object. The SoccerPlayer class contains the following properties:

    Name - The player’s name ( a string)
    JerseyNum - The player's jersey number (an integer)
    Goals - Number of goals scored (an integer)
    Assists - Number of assists (an integer)

*/
using static System.Console;
class TestSoccerPlayer
{
    static void Main()
    {
        // Write your main here.
    }
}
class SoccerPlayer
{
    public string Name;
    public int JerseyNum;
    public int Goals;
    public int Assists;

    public string Name1 { get { return Name; } set { Name = value; } }
    public int JerseyNum1 { get { return JerseyNum; } set { JerseyNum = value; } }
    public int Goals1 { get { return Goals; } set { Goals = value; } }
    public int Assists1 { get { return Assists; } set { Assists = value; } }
}
