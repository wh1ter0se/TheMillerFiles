bool reverseChronology = false
bool middleManUsed = false;
int endNumber;
int multiplier;
int multiplierType = 4;
    // 0 = multiplication
    // 1 = subtraction
    // 2 = addition
    // 3 = division
    // 4 = unselected
int runTime;
int startNumber;
List<string> finalOutput = new List<string>();
string currentEntry;
string middleMan;
 
// the listbox is named listOfEquations
// the start number input is named startNumberInput
// the end number input is named endNumberInput
// the multiplier input is named multiplierInput

public theOneThatDoesAllTheMath() {
if(-1 < multiplierType < 4) {
    if (startNumberInput.Value == NULL) {startNumber = 0;} else {startNumber = Convert.ToInt32(startNumberInput.Value);} if (endNumberInput.Value == NULL) {endNumber = 0;} else {endNumber = Convert.ToInt32(endNumberInput.Value);} if (multiplierInput.Value == NULL) {multiplier = 0;} else {multiplier = Convert.ToInt32(multiplierInput.Value);}
    // assign the values of start/end number
    if(endNumber < startNumber) {middleManUsed = true; middleMan = startNumber; startNumber = endNumber; endNumber = middleMan; middleMan = NULL;} runTime = ((endNumber + 1) - startNumber); if(middleManUsed == true) {reverseChronology = true; middleMan = startNumber; startNumber = endNumber; endNumber = middleMan; middleMan = NULL;}
    // swaps numbers around to get absolute difference for run time and sets chronology order AKA middle man code
    if(reverseChronology == false) {
       int i = 0;
       while(i < runTime) {
            if (multiplierType == 0) {currentEntry = (startNumber + i).ToString + " * " + multiplier.ToString + " = " + ((startNumber + i) * multiplier).ToString;}
            if (multiplierType == 1) {currentEntry = (startNumber + i).ToString + " - " + multiplier.ToString + " = " + ((startNumber + i) - multiplier).ToString;}
            if (multiplierType == 2) {currentEntry = (startNumber + i).ToString + " + " + multiplier.ToString + " = " + ((startNumber + i) + multiplier).ToString;}
            if (multiplierType == 3) {currentEntry = (startNumber + i).ToString + " ÷ " + multiplier.ToString + " = " + ((startNumber + i) / multiplier).ToString;}
            finalOutput.Add(currentEntry);
            i++;
       }
       listOfEquations.DataSource = finalOutput;
    }
    else {
       int i = runTime;
       while(i > 0) {
            if (multiplierType == 0) {currentEntry = (startNumber + i).ToString + " * " + multiplier.ToString + " = " + ((startNumber + i) * multiplier).ToString;}
            if (multiplierType == 1) {currentEntry = (startNumber + i).ToString + " - " + multiplier.ToString + " = " + ((startNumber + i) - multiplier).ToString;}
            if (multiplierType == 2) {currentEntry = (startNumber + i).ToString + " + " + multiplier.ToString + " = " + ((startNumber + i) + multiplier).ToString;}
            if (multiplierType == 3) {currentEntry = (startNumber + i).ToString + " ÷ " + multiplier.ToString + " = " + ((startNumber + i) / multiplier).ToString;}
            finalOutput.Add(currentEntry);
            i--;
       }
       listOfEquations.DataSource = finalOutput;
    }
    // clean up behind yourself
    currentEntry = NULL;
    middleManUsed = false;
    multiplierType = 4;
    reverseChronology = false;
}
else {
    window.alert("Please select a modifier.");
}
}

public theOneThatClearsEverythingUp() {
    
    
}