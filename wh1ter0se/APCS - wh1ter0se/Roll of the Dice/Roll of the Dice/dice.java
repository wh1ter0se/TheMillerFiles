import java.util.Random;

public class dice
{
    public dice()
    {
        
    }

    public String dieRoll(int runTimes)
    {
        String output = new String();
            output += "\r\n\r\n\r\n";
        Random rnd = new Random();
        int[][] rolls = new int[2][runTimes];
        int[] freqCount = new int[6];
        for (int i = 0; i < runTimes; i++) 
        {
            int rndNumber = rnd.nextInt(6) + 1;
            rolls[0][i] = rndNumber;
            freqCount[(rolls[0][i] - 1)]++;
            output += "[" + rolls[0][i] + "] ";
        }
        output += "\r\n";
        for (int n = 0; n < runTimes; n++) 
        {
            int rndNumber = rnd.nextInt(6) + 1;
            rolls[1][n] = rndNumber;
            freqCount[(rolls[1][n] - 1)]++;
            output += "[" + rolls[1][n] + "] ";
        }
        output += "\r\n"; output += "\r\n";
        for (int q = 1; q < 7; q++)
        {
            output += Integer.toString(q) + "- ";
            for (int k = 0; k < freqCount[(q -1)]; k++)
            {
                output += "X";
            }
            output += "\r\n";
        }
        return output;
    }
}
