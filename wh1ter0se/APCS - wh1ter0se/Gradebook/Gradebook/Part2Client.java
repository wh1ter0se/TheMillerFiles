/****************************************************
**
** Client class for Part 2
**
** This class is a Gradebook client, and is used
** to test the CategoryAssignment and CategoryGradebook
** classes.
**
** First, write a program that declares an CategoryAssignment 
** object, and then invokes all CategoryAssignment methods using
** that object. Print the return values to the screen, and
** verify that the CategoryAssignment class works properly. 
** Use your MainClass.java file from Part 1 as an example. 
** All methods available to CategoryAssignment objects, including
** those inherited from the Assignment class, must be tested. 
**
** Then, delete or comment out that code, and 
** write a program that declares a CategoryGradebook
** object, and adds CategoryAssignment objects to it. Then, 
** invoke the calculateGrade method on the CategoryGradebook
** object, and print the resulting value to the screen. 
** Use your MainClass.java from Part 1 as an example. Here
** are some grades that you can use:
**
** The two categories in this example are "Labs" and "Tests".
** Each has a weight of 50.
**
** name         pts available         pts earned    category
** Lab 1        30                    27            Labs
** Lab 2        30                    30            Labs
** Test 1       30                    30            Tests
** Lab 3        30                    30            Labs
** Lab 4        30                    30            Labs
** Test 2       30                    15            Tests
** Test 3       30                    0             Tests
** 
** The grade printed should be 73.75
**
** After this works, you should change your code so that the
** CategoryGradebook is instantiated with weights of 50 and 75
** in each category. The constructor should reduce the second
** weight to 50, and the grade calculated for this data should
** be the same as above.
**
** Then, instantiate the CategoryGradebook with weights of 50
** and 25 in each category. The constructor should increase the 
** second weight to 50, and the grade calculated for this data 
** should be the same as above.
**
****************************************************/
public class Part2Client {
    public static void main(String[] args) {
        
        // This code is used to test the CategoryAssignment class. 
        // Run this code first. 
        CategoryAssignment assign = new CategoryAssignment("Lab 1", 10, 9, "Labs");
        
        // this should print Lab 1
        System.out.println("Name of assign = " + assign.getName()); 
        
        // this should print 10
        System.out.println("Points possible = " + assign.getPointsPossible()); 
        
        // this should print 9
        System.out.println("Points earned = " + assign.getPointsEarned());
        
        // this should print Labs
        System.out.println("Category = " + assign.getCategoryName());
        
        
        
        String[] categories = new String[2];
            categories[0] = "Labs";
            categories[1] = "Tests";
        int[] weights = new int[2];
            weights[0] = 50;
            weights[1] = 50;
        CategoryGradebook gradebook = new CategoryGradebook(categories, weights);
        gradebook.add(new CategoryAssignment("Lab 1", 30, 27, "Labs"));
        gradebook.add(new CategoryAssignment("Lab 2", 30, 30, "Labs"));
        gradebook.add(new CategoryAssignment("Test 1", 30, 30, "Tests"));
        gradebook.add(new CategoryAssignment("Lab 3", 30, 30, "Labs"));
        gradebook.add(new CategoryAssignment("Lab 4", 30, 30, "Labs"));
        gradebook.add(new CategoryAssignment("Test 2", 30, 15, "Tests"));
        gradebook.add(new CategoryAssignment("Test 3", 30, 0, "Tests"));
        System.out.println("Grade = " + gradebook.calculateGrade());
    }
}
