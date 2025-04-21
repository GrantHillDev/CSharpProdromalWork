using PalindromeExercise;//for some reason, this was required in order for the project reference to work on this project file.... whereas on my previous unit testing assignment, this was not the case.... why? Gave me an unnecessary headache.
using System;//taking away the project reference which retains the same title as this using directive up above renders the typed out using directive unusable.... is, it seems that VSC just has a fickle attitude when it comes to how it handles C# related projects and their references.
using Xunit;//when in doubt of certain errors -- compile type errors being thrown in an IDE such as this (the project reference related error discussed above), I've taught myself that it's good practice to utilize the alt + enter hotkeys to trigger VSC's alternative to its intelliSense feature.... had to research this technique online, and now it's going to become one of my key tools for debugging any all future projects, at least in C# format.

namespace PalindromeExerciseTests//namespace PalindromeExerciseTests.tests//changing this file's extension to .tests seemed to make difference regards to the above aforementioned issue as it pertains to VSC's discrepancy with project referencing.
{
    public class UnitTest1
    {
        [Theory]//[Fact]
        [InlineData("racecar", true)]//one of the first items to look for in a code wars problem is its return type.
        [InlineData("crap", false)]
        [InlineData("Racecar", false)]//will need to have the .Tolower extension method embedded into the behavior of the IsAPalindrome method. Updated; not quite -- a palindrome that's pascal cased could be accounted for as an input or argument that could be passed into the method being tested for, but not necessarily as a unit test itself.
        [InlineData("Civic", false)]//these would have to be made to return false unless there's a way to have the same index of any array passed into the method we're testing for have its character capitalized.
        public void Test1(string word, bool expected)
        {
            //array
            var tester = new Palindrome();
            //actual
            var actual = tester.IsAPalindrome(word);//inferred typed, but VSC knows it's a Boolean.
            //assert
            Assert.Equal(expected, actual);//doesn't matter in what order these two arguments are written here.
            var test = new TrueCoders();//lol, I can make new objects or instances of classes inside the program.cs file, which probably means that I can make multiple classes in the same .cs file, and call them in the same manner.... though not sure what purpose that would serve, just yet.
        }
    }
}
