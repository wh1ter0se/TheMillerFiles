package util;

import java.net.InetAddress;
import java.net.UnknownHostException;

public class AddressChecker {
	public AddressChecker() {}
	
	public boolean isValid(String url) {
		try {
			System.setProperty("java.security.policy", System.getProperty("user.dir") + "\\src\\util\\java.policy");
			SecurityManager sm = new SecurityManager();
			System.setSecurityManager(sm);
			sm.checkConnect(url, 443);
	        return true;
	    }
	    catch (SecurityException e) {
	    	return false;
	    }
	}
}
