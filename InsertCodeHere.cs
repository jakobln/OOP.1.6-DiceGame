namespace DiceGame
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            DiceCup dc = new DiceCup();

            dc.Shake();
            System.Console.WriteLine($"The sum of your dice is {dc.TotalValue}");

            // The LAST line of code should be ABOVE this line
        }
    }
}