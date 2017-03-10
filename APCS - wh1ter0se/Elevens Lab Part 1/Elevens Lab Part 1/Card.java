/**
 * Card.java
 *
 * <code>Card</code> represents a playing card.
 */
public class Card {

    private String suit;
    private String rank;
    private int pointValue;

    public Card(String cardRank, String cardSuit, int cardPointValue) {
        suit = cardSuit;
        rank = cardRank;
        pointValue = cardPointValue;
    }

    public String suit() {
        return suit;
    }
   
    public String rank() {
        return rank;
    }
    
    public int pointValue() {
        return pointValue;
    }

    public boolean matches(Card otherCard) {
        boolean output = true;
        if (rank != otherCard.rank()) {output = false;}
        if (suit != otherCard.suit()) {output = false;}
        if (pointValue != otherCard.pointValue()) {output = false;}
        return output;
    }

    public String toString() {
        String output = (rank + " of " + suit + " (point value = " + pointValue + ")");
        return output;
    }
}