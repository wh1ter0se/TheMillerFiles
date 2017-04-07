package output;

import java.io.*;
import java.net.*;

public class Output {
	private static String NAME;
	private static String OUTPUT;
	private static URL URL;
	
	public static String sendToServer(String n) {
		try {
			NAME = n;
			URL = new URL("http://colton.yhscs.us/?name=" + NAME);
			URLConnection urlC = URL.openConnection(); urlC.setDoOutput(true);
			InputStream input = urlC.getInputStream();
			InputStream buffer = new BufferedInputStream(input);
			Reader reader = new InputStreamReader(buffer);

			int c;
			while ((c = reader.read()) != -1) { OUTPUT += (char) c; }
			return OUTPUT;
			// just use echo in the php file, and figure out where the code for the name game went
		} catch (MalformedURLException e) { System.err.println("Output:sendToServer; MalformedURLException"); } 
		  catch (IOException e) 		  { System.err.println("Output:sendToServer; IOException"); }
		return "ERROR";
	}
}
