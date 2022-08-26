
namespace StairPaths;

public class BruteForceStairPathsComputer : IStairPathsComputer
{
    public int ComputerNumberOfPaths(int numberOfStairs)
    {
        return ComputerNumberOfPaths(numberOfStairs, 0);
    }

    private int ComputerNumberOfPaths(int numberOfStairs, int stairIdx)
    {
        if (stairIdx >= numberOfStairs)
        {
            return 1;
        }

        int pathsFromNextStair = ComputerNumberOfPaths(numberOfStairs, stairIdx + 1);
        int pathsFromNextNextStair = ComputerNumberOfPaths(numberOfStairs, stairIdx + 2);
        int pathsFromNextNextNextStair = ComputerNumberOfPaths(numberOfStairs, stairIdx + 3);

        int pathsFromCurrentStair = pathsFromNextStair + pathsFromNextNextStair + pathsFromNextNextNextStair;

        return pathsFromCurrentStair;
    }
}
