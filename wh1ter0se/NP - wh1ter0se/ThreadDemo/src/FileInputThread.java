import java.io.*;

public class FileInputThread extends Thread {

	int[] output;
	FileInputStream fis;
	String fileName;
	
	public FileInputThread(String f) {
		fileName = f;
	}
	
	public void run() {
		try { fis = new FileInputStream(fileName); }
			catch (FileNotFoundException e) { System.err.println("there's nothing there"); }
		Input in = new Input(fis);
		output = in.getRoots();
	}
	
	public int[] getRoots() {
		return output;
	}

}
