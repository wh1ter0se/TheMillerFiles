package output;

import java.io.*;
import java.net.*;

public class Output {
	private static String NAME;
	private static URL URL;
	
	public void sendToServer(String n) {
		NAME = n;
		URL = new URL("http://colton.yhscs.us/");
		String query = ("name=" + NAME);
	}
}
