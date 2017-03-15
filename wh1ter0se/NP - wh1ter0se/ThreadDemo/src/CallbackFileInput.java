
public class CallbackFileInput implements Runnable {
	
	public int[] roots;
	
	public void run() {
		FileInputThread fit = new FileInputThread("input.txt");
		roots = fit.getRoots();
	}
	
	
}
