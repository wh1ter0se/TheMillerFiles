package HTMLSaver;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;

public class HTMLWriter {
	public HTMLWriter() {}
	
	public void write(String input, String fileName) {
		fileName += ".html";
		File file = new File(fileName);
		try { 
			FileWriter fw = new FileWriter(fileName);
			for (int i = 0; i < input.length(); i++) { fw.write(input.substring(i, i + 1)); }
			fw.write("test");
			fw.close(); 
		} 
			catch (FileNotFoundException e) { System.err.println("HTMLWriter:write | FileNotFound"); } 
			catch (IOException e) { System.err.println("HTMLWriter:write | IOException"); }
		
	}
}
