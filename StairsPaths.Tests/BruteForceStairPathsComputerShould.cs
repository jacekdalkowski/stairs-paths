using StairPaths;
using Xunit;

namespace StairsPaths;

public class BruteForceStairPathsComputerShould
{
    [Fact]
    public void Compute3PathsForSingleStep()
    {
        var bruteForceStairPathsComputer = new BruteForceStairPathsComputer();

        var numberOfPaths = bruteForceStairPathsComputer.ComputerNumberOfPaths(1);

        Xunit.Assert.Equal(3, numberOfPaths);
    }

    [Fact]
    public void Compute5PathsForTwoStep()
    {
        var bruteForceStairPathsComputer = new BruteForceStairPathsComputer();

        var numberOfPaths = bruteForceStairPathsComputer.ComputerNumberOfPaths(2);

        Xunit.Assert.Equal(5, numberOfPaths);
    }

    [Fact]
    public void Compute9PathsForThreeStep()
    {
        var bruteForceStairPathsComputer = new BruteForceStairPathsComputer();

        var numberOfPaths = bruteForceStairPathsComputer.ComputerNumberOfPaths(3);

        Xunit.Assert.Equal(9, numberOfPaths);
    }
}