import java.util.Scanner;

public class Main
{
    public static void Main(String[] args)
    {
        LoopyRectangle rect = new LoopyRectangle();
        LoopyTriangle tri = new LoopyTriangle();
        LoopyPyramid pyra = new LoopyPyramid();
        LoopyDiamond dia = new LoopyDiamond();
        LoopyDiamondOutline diaOutline = new LoopyDiamondOutline();
        System.out.println ("Type a shape: \r\nRectangle \r\nTriangle \r\nPyramid \r\nDiamond \r\nDiamond Outline\r\n\r\n");
        Scanner in = new Scanner (System.in);
        String statement = in.nextLine();
        while (statement.toLowerCase().equals("rectangle")) 
        {
            rect.main();
            System.out.println("\r\n");
        }
        while (statement.toLowerCase().equals("triangle")) 
        {
            tri.main();
            System.out.println("\r\n");
        }
        while (statement.toLowerCase().equals("pyramid")) 
        {
            pyra.main();
            System.out.println("\r\n");
        }
        while (statement.toLowerCase().equals("diamond")) 
        {
            dia.main();
            System.out.println("\r\n");
        }
        while (statement.toLowerCase().equals("diamond outline")) 
        {
            diaOutline.main();
            System.out.println("\r\n");
        }
    }

}
