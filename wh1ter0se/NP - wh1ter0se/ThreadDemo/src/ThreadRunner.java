import java.io.*;
import java.util.concurrent.*;

public class ThreadRunner {
	static String fileName;
	
	public ThreadRunner() {
		fileName = "input.txt";
	}
	
	public static void main(String[] args) {
		SingleLineInputThread[] slit = new SingleLineInputThread[15];
		for (int i = 0; i < 15; i++) {
			slit[i] = new SingleLineInputThread(fileName);
		}
	}
	
}
