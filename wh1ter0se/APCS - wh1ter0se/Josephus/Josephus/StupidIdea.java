import java.util.ArrayList;
/**
 * pretty self explanatory
 * 
 * @author wh1ter0se
 * @version 1.0
 */
public class StupidIdea
{
    private ArrayList<Integer> Kill_Order;
    private ArrayList<Integer> Remaining_People;
    private int Body_Count;
    private int Skip_Count;
    
    public int Main(int bodyCount, int skipCount) {
        AssignVars(bodyCount, skipCount);
        return WhoWillLive();
    }
    
    public void AssignVars(int b, int s) {
        Body_Count = b;
        Skip_Count = s;
        Kill_Order = new ArrayList<Integer>();
        Remaining_People = new ArrayList<Integer>();
        for (int i = 0; i < Body_Count; i++) {
            Remaining_People.add(i + 1);
        }
    }
    
    public int WhoWillLive() {
            int Josephus;
            int round = 0;
            int currentKill = -1;
            int maxPos = Remaining_People.size();
                while (Remaining_People.size() > 1) {
                    currentKill += Skip_Count;
                    if (currentKill > maxPos - 1) {
                        currentKill %= (maxPos);
                    }
                        int deadMan = Remaining_People.remove(currentKill);
                        Kill_Order.add(deadMan);
                         currentKill--;  
                   maxPos = Remaining_People.size();
                }
                int deadMan = Remaining_People.remove(0);
                Kill_Order.add(deadMan);
            Josephus = Kill_Order.get(Kill_Order.size() - 1);
            
        return Josephus;
    }
    
    public String PoliceReport() {
        String output = "\r\n\r\nHow it went down:\r\n";
        for (int i = 0; i < (Kill_Order.size()); i++) {
            output += Integer.toString(Kill_Order.get(i));
            output += " ";
        }
        return output;
    }
}
