package Runner;

import HTMLSaver.HTMLReader;
import HTMLSaver.HTMLWriter;
import util.AddressChecker;

public class Main {
	public static void main(String[] args) {
		String url = "http:/www.yhscs.us";
		String name = "yhscs";
		
		AddressChecker checker = new AddressChecker();
		HTMLReader reader = new HTMLReader();
		HTMLWriter writer = new HTMLWriter();
		
		if(checker.isValid(url)) { writer.write(reader.read(url), name); }
		
	}
}
