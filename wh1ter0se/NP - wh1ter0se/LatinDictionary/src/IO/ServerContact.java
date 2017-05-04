package IO;

import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.Reader;
import java.io.Writer;
import java.net.HttpURLConnection;
import java.net.InetAddress;
import java.net.Socket;
import java.net.URL;
import java.net.URLConnection;
import java.util.Arrays;

public class ServerContact {

	private static final char[] vowels = {'a', 'e', 'i', 'o', 'u'};
	
	public static String getLatin(String input) {
		String output = "Could not connect to dict.org. Check your connection and try again.";
		try {
			InetAddress dict = InetAddress.getByName("216.18.20.172");
			Socket socket = new Socket(dict, 2628);
		    OutputStream out = socket.getOutputStream();
		    InputStream in = socket.getInputStream();
		    Writer writer = new OutputStreamWriter(out);
		    Reader reader = new InputStreamReader(in);
		    writer.write("DEFINE fd-eng-lat " + input + "\r\n");
		    writer.flush();
		    int charInt;
		    output = "";
		    while ((charInt = reader.read()) != -1) {
		    	output = output + (char) charInt; 
		    	if (((char) charInt) == ("]").charAt(0)) { break; }
		    }
		    return inputToLatin(output, input);    
		} catch (IOException ex) { System.err.println(ex); }		
		return output;
	}
	
	public static String getTimeAndDate() {
		// TODO figure out how to contact serverside java
		return "Couldn't contact server";
	}
	
	private static String inputToLatin(String input, String engWord) {
		if (input.contains("250") && !input.contains("552")) {
			input = input.substring(input.indexOf(engWord));
			input = input.substring(input.indexOf(engWord, input.indexOf(engWord) + 1));
			input = input.substring(0, input.indexOf("\n."));
			return input; } 
		else {
			return pigLatin(engWord) == "-1" ? "No Translation" : pigLatin(engWord);}
	}
	
	public static String pigLatin(String word) { // I may or may not decide I have enough time to debug this
	    int start = 0, firstVowel = 0, end = word.length();
	    for(int i = 0; i < end; i++) {
	        char c = Character.toLowerCase(word.charAt(i));
	        if(Arrays.asList(vowels).contains(c)) { firstVowel = i; break; }}
	    if(start != firstVowel) {
	        String startString = word.substring(firstVowel, end);
	        String endString = word.substring(start, firstVowel) + "ay";
	        return startString+endString; }
	    return "-1";
	}
	
}
