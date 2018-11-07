namespace CSharpBasics.Interfaces
{
    public interface IPoint
    {
        // Uncomment, and it wouldn't compile
        // static int zero = 0;
        int X { get; set; }
        int Y { get; set; }
    }
}
