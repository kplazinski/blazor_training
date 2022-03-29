using BlazorTraining.Pages;
using Bunit;
using Xunit;

namespace BlazorTraining.UnitTests
{
    public class CounterComponentTests
    {
        [Fact]
        public void CounterShouldIncrementValue()
        {
            using (var context = new TestContext())
            {
                var counterComponent = context.RenderComponent<Counter>();

                counterComponent.Find("button.inc").Click();
                counterComponent.Find("span").MarkupMatches("<span>1</span>");

                counterComponent.Find("button.dec").Click();
                counterComponent.Find("span").MarkupMatches("<span>0</span>");

                counterComponent.Find("button.dec").Click();
                counterComponent.Find("span").MarkupMatches("<span>-1</span>");
            }
        }
    }
}