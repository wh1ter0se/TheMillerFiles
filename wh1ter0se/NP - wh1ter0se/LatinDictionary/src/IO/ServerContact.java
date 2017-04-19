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

public class ServerContact {

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
		    while ((charInt = reader.read()) != -1) { output = output + (char) charInt; }
		    return output;    
		} catch (IOException ex) { System.err.println(ex); }		
		return output;
	}
	
	public static String getTimeAndDate() {
		// figure out how to contact serverside java
		return "Couldn't contact server";
	}
	
}
