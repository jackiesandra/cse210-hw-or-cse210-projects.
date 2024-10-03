public class Fraction
{
    private int numerator;   // Private attribute for the numerator
    private int denominator; // Private attribute for the denominator

    // Default constructor: initializes to 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor that accepts only the numerator, sets the denominator to 1
    public Fraction(int numerator)
    {
        this.numerator = numerator; // Uses the passed value for the numerator
        denominator = 1;            // Sets the denominator to 1
    }

    // Constructor that accepts numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;   // Assigns the numerator
        this.denominator = denominator; // Assigns the denominator
    }

    // Getters and Setters
    public int GetNumerator() // Method to get the numerator
    {
        return numerator;
    }

    public void SetNumerator(int value) // Method to set the numerator
    {
        numerator = value;
    }

    public int GetDenominator() // Method to get the denominator
    {
        return denominator;
    }

    public void SetDenominator(int value) // Method to set the denominator
    {
        denominator = value;
    }

    // Method to get the string representation of the fraction
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}"; // Returns the string "numerator/denominator"
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator; // Divides the numerator by the denominator
    }
}
