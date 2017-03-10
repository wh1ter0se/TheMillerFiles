/**
 * This is a class that tests the Card class.
 */
public class CardTester {

        
    public static void main(String[] args) {
        TestFiveDiamonds();
        TestNineHearts();
        TestAceSpades();
    }
    
	public static void TestFiveDiamonds() {
	    Card davidSpade = new Card("Ace", "Spades", 10);
		Card fiveOfDiamonds = new Card("Five", "Diamonds", 5);
		System.out.println("\r\n" + fiveOfDiamonds.toString());
		System.out.println("The suit should be Diamonds, and is " + fiveOfDiamonds.suit());
		System.out.println("The rank should be Five, and is " + fiveOfDiamonds.rank());
		System.out.println("The point value should be 5, and is " + fiveOfDiamonds.pointValue());
		System.out.println("\'This card is David Spade\' should be false and is " + fiveOfDiamonds.matches(davidSpade));
	}	   
	
	public static void TestNineHearts() {
	    Card davidSpade = new Card("Ace", "Spades", 10);
		Card nineOfHearts = new Card("Nine", "Hearts", 9);
		System.out.println("\r\n" + nineOfHearts.toString());
		System.out.println("The suit should be Hearts, and is " + nineOfHearts.suit());
		System.out.println("The rank should be Nine, and is " + nineOfHearts.rank());
		System.out.println("The point value should be 9, and is " + nineOfHearts.pointValue());
		System.out.println("\'This card is David Spade\' should be false and is " + nineOfHearts.matches(davidSpade));
	}	
	
	public static void TestAceSpades() {
	    Card davidSpade = new Card("Ace", "Spades", 10);
		Card aceOfSpades = new Card("Ace", "Spades", 10);
		System.out.println("\r\n" + aceOfSpades.toString());
		System.out.println("The suit should be Spades, and is " + aceOfSpades.suit());
		System.out.println("The rank should be Ace, and is " + aceOfSpades.rank());
		System.out.println("The point value should be 10, and is " + aceOfSpades.pointValue());
		System.out.println("\'This card is David Spade\' should be true and is " + aceOfSpades.matches(davidSpade));
	}	
}
