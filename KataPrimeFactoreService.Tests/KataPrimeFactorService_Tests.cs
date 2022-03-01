using System.Collections.Generic;
using Xunit;

namespace KataPrimeFactoreService.Tests;

public class KataPrimeFactorService_Tests
{
    [Fact]
    public void DoNothing()
    {
        Assert.False(false);
    }

    [Fact]
    public void Given1ShouldReturnEmptyList()
    {
        Assert.Equal(new List<int>(), KataPrimeFactorService.Generate(1));
    }

    [Fact]
    public void Given2ShouldReturnListeWithNumber2()
    {
        Assert.Equal(new List<int> { 2 }, KataPrimeFactorService.Generate(2));
    }

    [Fact]
    public void Given3ShouldReturnListeWithNumber3()
    {
        Assert.Equal(new List<int> { 3 }, KataPrimeFactorService.Generate(3));
    }

    [Fact]
    public void Given14ShouldReturnListeWithNumbers2And7()
    {
        Assert.Equal(new List<int> { 2, 7 }, KataPrimeFactorService.Generate(14));
    }

    [Fact]
    public void Given100ShouldReturnListeWithNumbers2And2And5And5()
    {
        Assert.Equal(new List<int> { 2, 2, 5, 5 }, KataPrimeFactorService.Generate(100));
    }

    [Theory]
    [MemberData(nameof(GetListPrimeFactorsFromDataGenerator))]
    public void GivenNumberShouldReturnListeOfPrimeFactors(int number, List<int> expected)
    {
        Assert.Equal(expected, KataPrimeFactorService.Generate(number));
    }

    private static IEnumerable<object[]> GetListPrimeFactorsFromDataGenerator()
    {
        yield return new object[] { 30, new List<int> { 2, 3, 5 } };
        yield return new object[] { 200, new List<int> { 2, 2, 2, 5, 5 } };
        yield return new object[] { 50, new List<int> { 2, 5, 5 } };
    }
}