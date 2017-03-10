
/**
 * talks you how dumbs the StupedIdeea is
 * 
 * @author wh1ter0se
 * @version 1.0
 */
public class IQTester
{
    public static void Test59() {
        StupidIdea ChocolateHeatShelter = new StupidIdea();
        System.out.println("The position should be 2 and the order should be 4 5 3 1 2");
        System.out.println("The position is " + Integer.toString(ChocolateHeatShelter.Main(5,9)));
        System.out.println(ChocolateHeatShelter.PoliceReport());
    }
    
    public static void Test210() {
        StupidIdea ChocolateHeatShelter = new StupidIdea();
        System.out.println("The position should be 1 and the order should be 2 1");
        System.out.println("The position is " + Integer.toString(ChocolateHeatShelter.Main(2,10)));
        System.out.println(ChocolateHeatShelter.PoliceReport());
    }
    
    public static void Test102() {
        StupidIdea ChocolateHeatShelter = new StupidIdea();
        System.out.println("The position should be 5 and the order should be 2 4 6 8 10 3 7 1 9 5");
        System.out.println("The position is " + Integer.toString(ChocolateHeatShelter.Main(10,2)));
        System.out.println(ChocolateHeatShelter.PoliceReport());
    }
    
    public static void Test45() {
        StupidIdea ChocolateHeatShelter = new StupidIdea();
        System.out.println("The position should be 2 and the order should be 1 3 4 2");
        System.out.println("The position is " + Integer.toString(ChocolateHeatShelter.Main(4,5)));
        System.out.println(ChocolateHeatShelter.PoliceReport());
    }
}
