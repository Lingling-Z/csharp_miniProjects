namespace UnitTestLibrary.Tests
{
    public class GreetMessageTests
    {
        [Fact]
        public void GreetMessageShouldReturnGoodAfternoon()
        {
            GreetMessage message = new GreetMessage();
            string expected = "Good afternoon";
            string actual = message.Greetings(13);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, "Go to bed")]
        [InlineData(4, "Go to bed")]
        [InlineData(5, "Good morning")]
        [InlineData(11, "Good morning")]
        [InlineData(12, "Good afternoon")]
        [InlineData(17, "Good afternoon")]
        [InlineData(18, "Good evening")]
        [InlineData(23, "Good evening")]

        public void GreetMessageShouldReturnValue(int hourOfDay, string expected)
        {
            GreetMessage message = new GreetMessage();
            string actual = message.Greetings(hourOfDay);
            Assert.Equal(expected, actual);
        }
    }
}