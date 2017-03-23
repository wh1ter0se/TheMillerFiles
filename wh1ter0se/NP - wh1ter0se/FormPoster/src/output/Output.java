package output;

import java.io.*;
import java.net.*;

public class Output {
	private static String NAME;
	private static URL URL;
	
	public void sendToServer(String n) {
		try {
			NAME = n;
			URL = new URL("http://colton.yhscs.us/?name=" + NAME);
			URLConnection urlC = URL.openConnection();
			InputStream input = urlC.getInputStream();
			InputStream buffer = new BufferedInputStream(input);
			Reader reader = new InputStreamReader(buffer);

			int c;
			while ((c = reader.read()) != -1) { System.out.print((char)c); }
			
		} catch (MalformedURLException e) { System.err.println("Output:sendToServer; MalformedURLException"); } 
		  catch (IOException e) 		  { System.err.println("Output:sendToServer; IOException"); }
		
	}
}
