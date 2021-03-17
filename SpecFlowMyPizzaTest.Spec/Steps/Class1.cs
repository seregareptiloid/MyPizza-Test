using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowMyPizzaTest.Spec.Steps
{
    [Binding]
    class PizzaOrderStepDefinitions
    {
        [Given(@"a web browser is at mypizza home page")]
        public void GivenAWebBrowserIsAtMypizzaHomePage()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
