package server;

import java.net.InetAddress;
import java.net.UnknownHostException;

public class Contact {
	public final static String SERVER_ADDRESS = "https://www.colton.yhscs.us/";
	public static InetAddress SERVER_INET;
	
	public Contact() {
		SERVER_INET = null;
		try { SERVER_INET = InetAddress.getByName(SERVER_ADDRESS); } catch (UnknownHostException e) { System.err.println(e); }
	}
	
	public static String[] getModules() { //TODO actually retrieve modules from the database
		String[] modules = new String[1];
		return modules;
	}
}
