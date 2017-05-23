package diagnostics;

import org.hyperic.sigar.Mem;
import org.hyperic.sigar.SigarException;
import org.hyperic.sigar.jmx.SigarMem;

public class Hardware {
	
	public static double getRAM() {
		SigarMem.getMem();
		return mem.getRam();
	}
	
}
