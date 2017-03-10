package HTMLSaver;

import java.io.*;
import java.net.*;

public class HTMLReader {
	public HTMLReader() {}
	
	public String read(String address) {
		try {
			String output = "";
			URL urlIn = new URL(address);
			BufferedReader in = new BufferedReader( new InputStreamReader(urlIn.openStream()));
			String line;
	        while ((line = in.readLine()) != null)
	            output += line;
	        return output;
		}
			catch (MalformedURLException ex) { System.err.println("HTMLReader:read; MalformedURLException"); }
			catch (IOException ex) { System.err.println("HTMLReader:read; IOException"); }
		return "<html></html>";
	}
}
