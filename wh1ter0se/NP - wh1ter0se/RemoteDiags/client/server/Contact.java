package server;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.Reader;
import java.io.Writer;
import java.net.InetAddress;
import java.net.Socket;
import java.net.UnknownHostException;
import java.util.ArrayList;

import javax.net.SocketFactory;
import javax.net.ssl.SSLSocketFactory;

public class Contact {
	private final static String SERVER_ADDRESS = "https://www.colton.yhscs.us/";
	
	private static String OUTPUT_STRING;
	
	private static Socket SOCKET;
	private static SocketFactory FACTORY;
	
	private static InputStream IN;
		private static Reader READER;
	private static OutputStream OUT;
		private static Writer WRITER;
	
	public Contact() {
		try {
			FACTORY = SSLSocketFactory.getDefault();
			SOCKET = FACTORY.createSocket(SERVER_ADDRESS, 4343);
			} catch (UnknownHostException e) { System.err.println(e); }
		      catch (IOException e)          { System.err.println(e); } }
	
	// so the way this reads, the php needs to output items separated by * and end with ~
	public ArrayList<String> getModuleList() { //TODO actually retrieve modules from the database
		ArrayList<String> modules = null;
		try { 
			WRITER.write("list");
			WRITER.flush();
			
			int charInt; OUTPUT_STRING = "";
			while ((charInt = READER.read()) != -1) {
		    	OUTPUT_STRING = OUTPUT_STRING + (char) charInt; 
		    	if (((char) charInt) == ("~").charAt(0)) { break; } }
				} catch (IOException e) { System.err.println(e); }
		
			Boolean underway = true;
			while (underway) {
				if (OUTPUT_STRING.substring(0, 1) == "~") { underway = false; } else {
					modules.add(OUTPUT_STRING.substring(0, OUTPUT_STRING.indexOf("*")));
					OUTPUT_STRING = OUTPUT_STRING.substring(OUTPUT_STRING.indexOf("*") + 1); } }
			OUTPUT_STRING = "";
			return modules; }
	
	public String fetchConfigedMods(String config) {
		try {
			WRITER.write(config);
			int charInt; OUTPUT_STRING = "";
			while ((charInt = READER.read()) != -1) {
		    	OUTPUT_STRING = OUTPUT_STRING + (char) charInt; 
		    	if (((char) charInt) == ("~").charAt(0)) { break; } }
			return OUTPUT_STRING;
			} catch (IOException e) { System.err.println(e); }
		return ""; }
}
