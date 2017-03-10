

public class LoopyTriangle {
    public static void main() {
    	String output = new String();
    	String currentMessage = "* ";
    	for (int n = 0; n < 11; n++)
    	{
    	    output += currentMessage + "\r\n";
    	    currentMessage += "* ";
    	}
    	System.out.println(output);
    }
}
