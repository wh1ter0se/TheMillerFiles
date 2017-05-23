package output;

import java.io.*;
import java.net.*;
import java.nio.charset.StandardCharsets;

public class Output {
	private static String NAME;
	private static URL URL;
	
	public static void sendToServer(String n) {
		try {
			NAME = "name=" + n;
			URL = new URL("http://colton.yhscs.us/thenamegame.php");
			byte[] postData = NAME.getBytes( StandardCharsets.UTF_8 );
			HttpURLConnection urlC = (HttpURLConnection) URL.openConnection(); 
				urlC.setDoOutput(true); 
				urlC.setRequestMethod("POST");
				urlC.setRequestProperty("Content-Type", "application/x-www-form-urlencoded"); 
				urlC.setRequestProperty("charset", "utf-8");
				urlC.setRequestProperty("Content-Length", Integer.toString(NAME.length()));
				urlC.setUseCaches( false );
				try( DataOutputStream wr = new DataOutputStream( urlC.getOutputStream())) { wr.write( postData ); }
			InputStream input = urlC.getInputStream();
			InputStream buffer = new BufferedInputStream(input);
			Reader reader = new InputStreamReader(buffer);

			int c;
			while ((c = reader.read()) != -1) { System.out.print((char)c); }
			
		} catch (MalformedURLException e) { System.err.println("Output:sendToServer; MalformedURLException"); } 
		  catch (IOException e) 		  { System.err.println("Output:sendToServer; IOException"); }
		
	}
}
