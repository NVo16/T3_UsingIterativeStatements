// See https://aka.ms/new-console-template for more information
/* 
    Programmer: Ngoc Vo
    Date: 02/06/2022
    Assignment: T-3 Using Iterative Statements
    Description: This C# Console application code demonstrates the use of iterative 
    statement after getting input from users.
*/
// Ask the user for the input
Console.Write("Please Enter the CAD Increment Value: ");
/* 
    Use the try-catch block to validate user input so the catch block will handle 
    the error and display the message if user enters inappropriate input
*/
try
{
    // Declare variable to store user input
    string input = Console.ReadLine();
    // Declare variable to perform the iterative statement and be parsed as a decimal literal from the user input
    decimal incrementValue = decimal.Parse(input);
    // Declare variable for the minimum and maximum CAD Increment Value
    const decimal MIN_INCREMENT_VALUE = 5m;
    const decimal MAX_INCREMENT_VALUE = 25m;
    // Declare variable to store the CAD dollar value
    decimal cadValue = 0m;
    // Declare variable for the maximum CAD dollar value
    const decimal MAX_CAD_VALUE = 200m;
    // Declare variable to store the US dollar value
    decimal usValue = 0m;
    // Declare variable for the value converting the CAD dollar value to US dollar value
    const double CONVERSION_VALUE = 0.792367;
    /*
        Use the conditional if/else statement to check the value that user enters.
        If the user input is between $5 and $25, display the message and execute the While loop.
        If not, the user is asked to exit the program and try again.
    */
    if ((incrementValue >= MIN_INCREMENT_VALUE) && (incrementValue <= MAX_INCREMENT_VALUE))
    {
        // Display message demonstrating the increment value that the user enters
        Console.WriteLine("The CAD Increment Value: {0:C}", incrementValue);
        // Display message showing the table header
        Console.WriteLine("{0,-10:C} {1,-10:C}", "CAD$", "US$");
        // Use the While loop to convert the CAD dollar value to the US dollar value if the CAD dollar value is between $0 and $200
        while (cadValue <= MAX_CAD_VALUE)
        {
            // Multiply the CAD dollar value with the conversion value to get the US dollar value
            usValue = cadValue * (decimal)CONVERSION_VALUE;
            // Show the CAD dollar value and US dollar value as a table
            Console.WriteLine("{0,-10:C} {1,-10:C}", cadValue, usValue);
            // Increase the CAD dollar value by the increment value
            cadValue = cadValue + incrementValue;
        } // End of While loop
        // Display message guiding the user to exit
        Console.WriteLine("Press Any Key To Exit The Program.");
        // Pause for user to press any key
        Console.ReadKey(true);
    } // End of if
    else
    {
        // Display messages demonstrating the accepted range of the increment value and asking the user to try again
        Console.WriteLine("Please Enter the CAD Increment Value between {0:C} and {1:C}.", MIN_INCREMENT_VALUE, MAX_INCREMENT_VALUE);
        Console.WriteLine("Please Try Running The Program Again.");
        Console.WriteLine("Press Any Key To Exit The Program And Try Again.");
        // Pause for user to press any key
        Console.ReadKey(true);
    } // End of else
} // End of try
catch
{
    // Display the message asking for the appropriate input and asking the user to try again
    Console.WriteLine("Please Enter the Integer Value And Try Running The Program Again.");
    Console.WriteLine("Press Any Key To Exit The Program And Try Again.");
    // Pause for user to press any key
    Console.ReadKey(true);
} // End of catch