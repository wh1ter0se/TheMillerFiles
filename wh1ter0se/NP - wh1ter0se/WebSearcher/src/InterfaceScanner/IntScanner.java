package InterfaceScanner;

import java.net.InetAddress;
import java.net.NetworkInterface;
import java.net.SocketException;
import java.util.Collections;
import java.util.Enumeration;

public class IntScanner {

	public static void scanInts() {
		try {
			Enumeration<NetworkInterface> netInts = NetworkInterface.getNetworkInterfaces();
			while (netInts.hasMoreElements()) {
				NetworkInterface net = netInts.nextElement();
				System.out.println("Display name: " + net.getDisplayName());
		        System.out.println("Name: " + net.getName());
		        Enumeration<InetAddress> inetAddresses = net.getInetAddresses();
		        for (InetAddress inetAddress : Collections.list(inetAddresses)) { System.out.println("InetAddress:" + inetAddress + "\r\n"); }}
		} catch (SocketException e) { System.err.println("Scanner:scan; SocketException");}	
	}
	
}
