package UI;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.Authenticator;
import java.net.InetAddress;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.UnknownHostException;

import authenticator.CustomAuthenticator;

public class URLReader {
	public URLReader() {}

	public static String read(URL inx) { //pretend that secure.php is password protected because I couldn't find a good site
		try {
			Authenticator.setDefault(new CustomAuthenticator());
			URL urlIn = inx;
			String output = "";
			BufferedReader in = new BufferedReader( new InputStreamReader(urlIn.openStream()));
			String line;
	        while ((line = in.readLine()) != null)
	            output += line;
	        return output.substring(0, output.indexOf(">") + 1); }
				catch (MalformedURLException ex) { System.err.println("HTMLReader:read; MalformedURLException"); }
				catch (IOException ex) { System.err.println("HTMLReader:read; IOException"); }
				catch (NullPointerException ex) { System.err.println("HTMLReader:read; NullPointerException"); }
		return "\r\n<html></html>"; }
}
