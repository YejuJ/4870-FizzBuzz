namespace FizzBuzzTests;
using FizzBuzzLibrary;

public class UnitTests
{
    [Fact]
    public void Given1Output1()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        string? actual = fb.GetOutput(1);
        string? expected = "1 ";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given3Output12Fizz()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        string? actual = fb.GetOutput(3);
        string? expected = "1 2 Fizz ";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given5Output12Fizz4Buzz()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        string? actual = fb.GetOutput(5);
        string? expected = "1 2 Fizz 4 Buzz ";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given15Output12Fizz_Buzz()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        string? actual = fb.GetOutput(15);
        string? expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ";
        Assert.Equal(expected, actual);
    }

    // Write a test that throws an Exception if the input is negative number
    [Fact]
    public void GivenNegativeOutputEmpty()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        Assert.Throws<Exception>(() => fb.GetOutput(-1));
    }

    //write a text that throws an exception if the input is bigger than 100
    [Fact]
    public void GivenNumberGreaterThan100OutputException()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        Assert.Throws<Exception>(() => fb.GetOutput(101));
    }

    [Fact]
    public void GivenNullOutputException()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        Assert.Throws<Exception>(() => fb.GetOutput(null));
    }

    [Fact]
    public void Given0OutputEmpty()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        string? actual = fb.GetOutput(0);
        // string? expected = "";
        string? expected = null;
        Assert.Equal(expected, actual);
    }

}