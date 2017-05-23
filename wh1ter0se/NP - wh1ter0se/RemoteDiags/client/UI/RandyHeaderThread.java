package UI;

import java.io.IOException;
import java.net.URL;
import java.util.Random;

public class RandyHeaderThread extends Thread {
	public static URL url;
	
	public RandyHeaderThread(URL url) {
		this.url = url; }
	
	public void run() {
		Random rnd = new Random();
		String out = "";
		out += rnd.nextInt(9) + rnd.nextInt(9) + " ";
		out += URLReader.read(url); 
		System.out.print("\033[H\033[2J");
		System.out.flush();
		System.out.println(out); }
}
