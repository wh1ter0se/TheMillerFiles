/****************************************************
**
** CategoryGradebook class
**
** This class represents a CategoryGradebook that calculates
** grades according to the weighted category grading system.
**
****************************************************/

import java.util.ArrayList;

public class CategoryGradebook implements Gradebook {
    private ArrayList<CategoryAssignment> myGrades;
    private String[] myCategories;
    private int[] myWeights;
    
    private double[] catMaxPoints; // max points per category; index matches myCategories index
    private double[] catEarnedPoints; // earned points per category; index matches myCategories index

    public CategoryGradebook(String[] categories, int[] weights) {
        myCategories = categories;
        myWeights = weights;
        
        catMaxPoints = new double[1000];
        catEarnedPoints = new double[1000];
        
        myGrades = new ArrayList<CategoryAssignment>();
    }
    
    public void add(Assignment assign) {
        CategoryAssignment catAssign = (CategoryAssignment)assign;
        myGrades.add(catAssign);
    }

    public double calculateGrade() {
        double total = 0;
        for (int i = 0; i < myGrades.size(); i++) {
            CategoryAssignment currAssign = myGrades.get(i);
            catMaxPoints[findCategory(currAssign)] += currAssign.getPointsPossible();
            catEarnedPoints[findCategory(currAssign)] += currAssign.getPointsEarned();
        }
        boolean zeroFound = false; int n = 0;
        while (!zeroFound) {
            if (myCategories[n].equals("") || myCategories[n].equals(null)) {
                zeroFound = true;
            } else if (n < myCategories.length - 1) {
                n++;
            }
        }
        for (int i = 0; i < n; i++) {
            catMaxPoints[i] *= (myWeights[i] / 100);
            catEarnedPoints[i] *= (myWeights[i] / 100);
            total += (catEarnedPoints[i] / catMaxPoints[i]);
        }
        return total;
    }
    
    // returns index of category or -1 for none
    private int findCategory(Assignment assign) {
        int i;
        CategoryAssignment catAssign = (CategoryAssignment)assign;
        for (i = 0; i < myCategories.length; i++) {
            if (catAssign.getCategoryName().equals(myCategories[i])) {
                return i;
            }
        }
        return -1;
    }
}
