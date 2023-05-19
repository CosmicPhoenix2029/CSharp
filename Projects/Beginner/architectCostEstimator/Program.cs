
class ArchitectCostEstimator
{
    public static void Main(string[] args)
    {
        CalculateTotalCost();
    }

    //methods to calculate the area for differant shapes
    static double Rectangle(double length, double width)
    {
        return length * width;
    }

    static double Circle(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    static double Triangle(double bottom, double height)
    {
        return 0.5 * bottom * height;
    }

    static void CalculateTotalCost() 
    {
        //here I have broken down an existing floor plan into a series of shapes
        double totalArea = Rectangle(2500, 1500) + Circle(375) + Triangle(750, 500);

        //total cost = cost of flooring material * cost per metre squared
        double cost = 180;
        double totalCost = totalArea * cost;
        Console.WriteLine($"The total cost for a floor plan of {Math.Round(totalArea, 2)} metres, is {Math.Round(totalCost, 2)} Mexican Pesos!");
    }
}