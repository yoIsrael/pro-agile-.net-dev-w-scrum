// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.5.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace KojackGames.Blackjack.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Double Down")]
    public partial class DoubleDownFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "007-DoubleStake.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Double Down", "In order to double my stake\r\nAs a player\r\nI should be offered to double down when" +
                    " my initial\r\ntwo cards add up to 9, 10 or 11", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Offer to double")]
        public virtual void OfferToDouble()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Offer to double", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Name",
                        "Password"});
            table1.AddRow(new string[] {
                        "Scott@elbandit.co.uk",
                        "Scott",
                        "Cheese@123"});
#line 8
 testRunner.Given("that I have logged in with an account with the following details", ((string)(null)), table1);
#line 11
 testRunner.And("I have started a new game and bet \"5\"");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Suit",
                        "Value"});
            table2.AddRow(new string[] {
                        "Diamonds",
                        "Eight"});
            table2.AddRow(new string[] {
                        "Hearts",
                        "Ten"});
            table2.AddRow(new string[] {
                        "Hearts",
                        "Two"});
            table2.AddRow(new string[] {
                        "Hearts",
                        "Three"});
#line 12
 testRunner.And("the deck contains the following cards:", ((string)(null)), table2);
#line 18
 testRunner.And("I have navigated to the game play screen to play a hand");
#line 19
 testRunner.When("I click on the deal button");
#line 20
 testRunner.Then("I should be offered to double my stake");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Trying to double down without enough money")]
        public virtual void TryingToDoubleDownWithoutEnoughMoney()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Trying to double down without enough money", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Name",
                        "Password"});
            table3.AddRow(new string[] {
                        "Scott@elbandit.co.uk",
                        "Scott",
                        "Cheese@123"});
#line 23
 testRunner.Given("that I have logged in with an account with the following details", ((string)(null)), table3);
#line 26
 testRunner.And("I have started a new game and bet \"10\"");
#line 27
 testRunner.And("I have \"1\" dollars in my pot");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Suit",
                        "Value"});
            table4.AddRow(new string[] {
                        "Diamonds",
                        "Eight"});
            table4.AddRow(new string[] {
                        "Hearts",
                        "Ten"});
            table4.AddRow(new string[] {
                        "Clubs",
                        "Two"});
            table4.AddRow(new string[] {
                        "Hearts",
                        "Three"});
#line 28
 testRunner.And("the deck contains the following cards:", ((string)(null)), table4);
#line 34
 testRunner.And("I have navigated to the game play screen to play a hand");
#line 35
 testRunner.When("I click on the deal button");
#line 36
 testRunner.When("I click on the double button");
#line 37
 testRunner.Then("I should be asked \"Please cash in to Double Down. You need at least $10.00 dollar" +
                    "s.\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Double Down and lose")]
        public virtual void DoubleDownAndLose()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Double Down and lose", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Name",
                        "Password"});
            table5.AddRow(new string[] {
                        "Scott@elbandit.co.uk",
                        "Scott",
                        "Cheese@123"});
#line 40
 testRunner.Given("that I have logged in with an account with the following details", ((string)(null)), table5);
#line 43
 testRunner.And("I have started a new game and bet \"10\"");
#line 44
 testRunner.And("I have \"30\" dollars in my pot");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Suit",
                        "Value"});
            table6.AddRow(new string[] {
                        "Diamonds",
                        "Nine"});
            table6.AddRow(new string[] {
                        "Hearts",
                        "Ten"});
            table6.AddRow(new string[] {
                        "Hearts",
                        "Two"});
            table6.AddRow(new string[] {
                        "Clubs",
                        "Two"});
            table6.AddRow(new string[] {
                        "Spades",
                        "Two"});
            table6.AddRow(new string[] {
                        "Hearts",
                        "Seven"});
#line 45
 testRunner.And("the deck contains the following cards:", ((string)(null)), table6);
#line 53
 testRunner.And("I have navigated to the game play screen to play a hand");
#line 54
 testRunner.When("I click on the deal button");
#line 55
 testRunner.When("I click on the double button");
#line 56
 testRunner.Then("my pot should show \"$20.00\" dollars");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Double Down and win")]
        public virtual void DoubleDownAndWin()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Double Down and win", ((string[])(null)));
#line 58
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Name",
                        "Password"});
            table7.AddRow(new string[] {
                        "Scott@elbandit.co.uk",
                        "Scott",
                        "Cheese@123"});
#line 59
 testRunner.Given("that I have logged in with an account with the following details", ((string)(null)), table7);
#line 62
 testRunner.And("I have started a new game and bet \"10\"");
#line 63
 testRunner.And("I have \"30\" dollars in my pot");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Suit",
                        "Value"});
            table8.AddRow(new string[] {
                        "Diamonds",
                        "Eight"});
            table8.AddRow(new string[] {
                        "Hearts",
                        "Ten"});
            table8.AddRow(new string[] {
                        "Clubs",
                        "Two"});
            table8.AddRow(new string[] {
                        "Hearts",
                        "Three"});
            table8.AddRow(new string[] {
                        "Hearts",
                        "Two"});
            table8.AddRow(new string[] {
                        "Hearts",
                        "Jack"});
            table8.AddRow(new string[] {
                        "Hearts",
                        "King"});
#line 64
 testRunner.And("the deck contains the following cards:", ((string)(null)), table8);
#line 73
 testRunner.And("I have navigated to the game play screen to play a hand");
#line 74
 testRunner.When("I click on the deal button");
#line 75
 testRunner.When("I click on the double button");
#line 76
 testRunner.Then("my pot should show \"$70.00\" dollars");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion