namespace CoreTest
{
    using Core;

    public class ReproTests
    {
        public void Should_not_blow_up()
        {
            var target = new Target();

            target.DoSomething();
        }
    }
}
