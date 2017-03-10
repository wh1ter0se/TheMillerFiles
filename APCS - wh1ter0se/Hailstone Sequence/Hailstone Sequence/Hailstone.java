
/**
 * Write a description of class Hailstone here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Hailstone
{
    public static void KiloRace() {
        int[] highestLength = new int[5];
        int[] highestVal = new int[5];
        int[] lengthSeeds = new int[5];
        int[] valSeeds = new int[5];
        String numCounts = new String();
        int a = 0;
        for (int i = 0; i < 1000; i++) {
            int currentNumb = i + 1; // currentNumb
            int length = 1;
            int highVal = currentNumb;
            numCounts += currentNumb + " ";
            a = currentNumb;
            String loading = "Loading....... ";
            loading += (a / 10) + "%";
            System.out.println(loading);
            while (currentNumb != 1) {
                if (currentNumb % 2 == 0) {currentNumb /= 2;} else {currentNumb *= 3; currentNumb++;}
                if (highVal < currentNumb) {highVal = currentNumb;}
                numCounts += currentNumb + " ";
                length++;
            }
            numCounts += "\r\nLength: " + length + "    Highest value: " + highVal + "\r\n\r\n";
            for (int j = 0; j < 5; j++) {
                if (highestVal[j] < highVal) {
                    for (int q = 4; q > j; q--) {
                        highestVal[(q)] = highestVal[q - 1];
                    }
                    for (int q = 4; q > j; q--) {
                        valSeeds[(q)] = valSeeds[q - 1];
                    }
                    highestVal[j] = highVal;
                    valSeeds[j] = a;
                    j = 5;
                }
            }
            for (int j = 0; j < 5; j++) {
                if (highestLength[j] < length) {
                    for (int q = 4; q > j; q--) {
                        highestLength[(q)] = highestLength[q - 1];
                    }
                    for (int q = 4; q > j; q--) {
                        lengthSeeds[(q)] = lengthSeeds[q - 1];
                    }
                    highestLength[j] = length;
                    lengthSeeds[j] = a;
                    j = 5;
                }
            }
        }
        
        System.out.println(numCounts);
        String output = "Highest values: ";
        for (int i = 0; i < 5; i++) {
            output += "[" + highestVal[i] + " (" + valSeeds[i] + ")" + "]    ";
        }
        System.out.println(output);
        output = "Highest lengths: ";
        for (int i = 0; i < 5; i++) {
            output += "[" + highestLength[i] + " (" + lengthSeeds[i] + ")" + "]    ";
        }
        System.out.println(output);
    }
}
