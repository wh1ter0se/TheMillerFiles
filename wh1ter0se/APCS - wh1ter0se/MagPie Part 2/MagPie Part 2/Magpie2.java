/**
 * A program to carry on conversations with a human user.
 * This is the initial version that:  
 * <ul><li>
 *       Uses indexOf to find strings
 * </li><li>
 *          Handles responding to simple words and phrases 
 * </li></ul>
 * This version uses a nested if to handle default responses.
 * @author Laurie White
 * @version April 2012
 */
public class Magpie2
{
    /**
     * Get a default greeting   
     * @return a greeting
     */
    public String getGreeting()
    {
        return "Hello, let's talk.";
    }
    
    /**
     * Gives a response to a user statement
     * 
     * @param statement
     *            the user statement
     * @return a response based on the rules given
     */
    public String getResponse(String statement)
    {
        String response = "";
        String trimmedStatement = statement.trim();
        if (statement.indexOf("no") >= 0)
        {
            response = "Why so negative?";
        }
        else if (statement.toLowerCase().indexOf("mother") >= 0
                || statement.toLowerCase().indexOf("father") >= 0
                || statement.toLowerCase().indexOf("sister") >= 0
                || statement.toLowerCase().indexOf("brother") >= 0)
        {
            response = "Tell me more about your family.";
        }
        else if (statement.toLowerCase().indexOf("dog") >= 0
                || statement.toLowerCase().indexOf("cat") >= 0)
        {
            response = "Tell me more about your pets.";
        }
        else if (statement.toLowerCase().indexOf("miller") >= 0)
        {
            response = "He sounds like a dank meme farmer";
        }
        else if (trimmedStatement.toLowerCase().equals(""))
        {
            response = "Speak up, child";
        }
        else if (statement.toLowerCase().indexOf("memes") >= 0)
        {
            response = "It's pronounced 'meemays' you uncultured swine";
        }
        else if (statement.toLowerCase().indexOf("gaben") >= 0
                || statement.toLowerCase().indexOf("steam") >= 0)
        {
            response = "STEAM SALE ONE DAY ONLY 99% OFF EVERYTHING";
        }
        else if (statement.toLowerCase().indexOf("cod") >= 0
                || statement.toLowerCase().indexOf("call of duty") >= 0)
        {
            response = "Please go home and destroy your videogaming device";
        }
        else
        {
            response = getRandomResponse();
        }
        return response;
    }

    /**
     * Pick a default response to use if nothing else fits.
     * @return a non-committal string
     */
    private String getRandomResponse()
    {
        final int NUMBER_OF_RESPONSES = 6;
        double r = Math.random();
        int whichResponse = (int)(r * NUMBER_OF_RESPONSES);
        String response = "";
        
        if (whichResponse == 0)
        {
            response = "Interesting, tell me more.";
        }
        else if (whichResponse == 1)
        {
            response = "Hmmm.";
        }
        else if (whichResponse == 2)
        {
            response = "Do you really think so?";
        }
        else if (whichResponse == 3)
        {
            response = "You don't say.";
        }
        else if (whichResponse == 4)
        {
            response = "Well isn't that fine and dandy.";
        }
        else if (whichResponse == 5)
        {
            response = "I'll be honest here, that's a pretty boring topic.";
        }
        return response;
    }
}
