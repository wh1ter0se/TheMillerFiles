
import java.util.Scanner;

public class HighRoller
{
	public static void main(String[] args)
	{
		dice fuzzyBoxes = new dice();
		
		System.out.println ("How many times do you want to roll the dice?");
		Scanner in = new Scanner (System.in);
		int times = Integer.parseInt(in.nextLine());
		
		if (times > 0)
		{
			System.out.println (fuzzyBoxes.dieRoll(times));
		}
	}

}