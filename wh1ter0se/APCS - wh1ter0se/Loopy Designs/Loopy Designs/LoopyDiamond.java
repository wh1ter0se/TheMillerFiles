
public class LoopyDiamond {
    public static void main() {
        int spaceCount = 5;
        int starCount = 1;
        String output = new String();
        for (int k = 0; k < 6; k++)
        {
            for (int p = 0; p < spaceCount; p++)
            {
                output += " ";
            }
            for (int g = 0; g < starCount; g++)
            {
                output += "*";
            }
            spaceCount--;
            starCount += 2;
            output += "\r\n";
        }
        spaceCount += 2;
        starCount -= 4;
        for (int q = 0; q < 6; q++)
        {
            for (int p = 0; p < spaceCount; p++)
            {
                output += " ";
            }
            for (int g = 0; g < starCount; g++)
            {
                output += "*";
            }
            spaceCount++;
            starCount -= 2;
            output += "\r\n";
        }
        System.out.println(output);
    }
}