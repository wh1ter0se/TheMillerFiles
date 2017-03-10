
public class LoopyDiamondOutline {
    public static void main() {
        int spaceCount = 4;
        int starCount = 3;
        String output = new String();
        output += "     *\r\n";
        for (int k = 0; k < 5; k++)
        {
            for (int p = 0; p < spaceCount; p++)
            {
                output += " ";
            }
            output += "*";
            for (int g = 0; g < (starCount - 2); g++)
            {
                output += " ";
            }
            output += "*";
            spaceCount--;
            starCount += 2;
            output += "\r\n";
        }
        spaceCount += 2;
        starCount -= 4;
        for (int q = 0; q < 4; q++)
        {
            for (int p = 0; p < spaceCount; p++)
            {
                output += " ";
            }
            output += "*";
            for (int g = 0; g < starCount - 2; g++)
            {
                output += " ";
            }
            output += "*";
            spaceCount++;
            starCount -= 2;
            output += "\r\n";
        }
        output += "     *";
        System.out.println(output);
    }
}