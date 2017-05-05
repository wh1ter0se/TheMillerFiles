package diagnostics;

public class Hardware {
	
	public static double getRAM() {
		Mem mem = null;
		try { mem = sigar.getMem(); } catch (SigarException se) {  System.err.println(se); }
		return mem.getRam();
	}
	
	public static double 
}
