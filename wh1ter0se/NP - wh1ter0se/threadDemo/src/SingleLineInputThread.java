import java.io.*;

public class SingleLineInputThread extends Thread {
	Input in;
	int root;
	String fileName;
	
	public SingleLineInputThread(String f) {
		fileName = f;
	}
	
	public void run() {
		try { in = new Input(new FileInputStream(fileName)); }
		catch (FileNotFoundException e) { System.err.println("there's nothing there"); }
		root = in.getRoot();
	}
	
	public int getRoot() {
		return root;
	}
}
