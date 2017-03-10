import java.util.Scanner;

/**
 * pretty self explanatory
 * 
 * @author wh1ter0se
 * @version 1.0
 */
public class executioner
{
    public static void main(String[] args) {
        StupidIdea KillEachother = new StupidIdea(); // yes, I did name the entire class "StupidIdea" for this joke
        int questionNum = 0;
        int bodyCount = 1;
        int skipCount = 1;
        int josephus;
        System.out.println("How many people are there?");
        Scanner in = new Scanner (System.in);
        String statement = in.nextLine();
        while (!statement.equals("")) {
            if (questionNum == 0) {
                bodyCount = Integer.parseInt(statement);
                questionNum = 1;
                System.out.println("How many people should be skipped each time?");
                statement = in.nextLine();
            } else if (questionNum == 1) {
                skipCount = Integer.parseInt(statement);
                josephus = KillEachother.Main(bodyCount, skipCount);
                System.out.println("                       ______ \r\n                     <((((((\\\\\\ \r\n                     /      .  \\ \r\n                     ;--..--._|) \r\n  (\\                 '--/\\--'  ) \r\n   \\\\                | '-'  :'| \r\n    \\\\               . -==- .-| \r\n     \\\\               \\.__.'   \\--._ \r\n     [\\\\          __.--|        /  _/'--. \r\n     \\_\\\\       .'-._ ('-----'/ __/      \\ \r\n      \\_\\\\     /   __>|      | '--.       | \r\n       \\_\\\\   |   \\   |     /    /       / \r\n        \\ '\\ /     \\  |     |  _/       / \r\n         \\  \\       \\ |     | /        / \r\n          \\  \\       \\        / ");
                System.out.println("Stand in position " + Integer.toString(josephus) + " if you want to live");
                System.out.println(KillEachother.PoliceReport());
                // questionNum = 1852142180; // convert decimal -> hexadecimal -> binary -> text
                questionNum = 0;
                System.out.println("How many people are there?");
                statement = in.nextLine();
            }
        }
    }
}
