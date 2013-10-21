﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HangFire.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ClientFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Client.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Client", "", ProgrammingLanguage.CSharp, new string[] {
                        "redis"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Client")))
            {
                HangFire.Tests.ClientFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line 5
    testRunner.Given("a client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The client creates the job in the storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void TheClientCreatesTheJobInTheStorage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The client creates the job in the storage", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 8
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
     testRunner.Then("the storage contains the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The job contains the \'Type\' parameter equal to the assembly qualified type name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void TheJobContainsTheTypeParameterEqualToTheAssemblyQualifiedTypeName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The job contains the \'Type\' parameter equal to the assembly qualified type name", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 12
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table1.AddRow(new string[] {
                        "Type",
                        "<Assembly qualified name of \'HangFire.Tests.TestJob\' type>"});
#line 13
     testRunner.Then("it has the following parameters:", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("If the arguments were not provided, the \'Args\' parameter contains the empty JSON " +
            "value")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void IfTheArgumentsWereNotProvidedTheArgsParameterContainsTheEmptyJSONValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("If the arguments were not provided, the \'Args\' parameter contains the empty JSON " +
                    "value", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 18
     testRunner.When("I create an argumentless job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table2.AddRow(new string[] {
                        "Args",
                        "{}"});
#line 19
     testRunner.Then("it has the following parameters:", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Arguments are converted to a JSON string and contained in the \'Args\' parameter")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ArgumentsAreConvertedToAJSONStringAndContainedInTheArgsParameter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Arguments are converted to a JSON string and contained in the \'Args\' parameter", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table3.AddRow(new string[] {
                        "ArticleId",
                        "5"});
            table3.AddRow(new string[] {
                        "State",
                        "Deleted"});
#line 24
     testRunner.When("I create a job with the following arguments:", ((string)(null)), table3, "When ");
#line 28
     testRunner.Then("the job contains all of the above arguments in the JSON format", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The given state was applied to the job")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void TheGivenStateWasAppliedToTheJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The given state was applied to the job", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 31
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
     testRunner.Then("the given state was applied to it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Creating a job with an empty id causes an exception")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void CreatingAJobWithAnEmptyIdCausesAnException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating a job with an empty id causes an exception", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 35
     testRunner.When("I create a job with an empty id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
     testRunner.Then("A \'System.ArgumentNullException\' is thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Creating a job with an empty type causes an exception")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void CreatingAJobWithAnEmptyTypeCausesAnException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating a job with an empty type causes an exception", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 39
     testRunner.When("I create a job with null type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
     testRunner.Then("A \'System.ArgumentNullException\' is thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Creating a job with the type, that is not derived from the \'BackgroundJob\' causes" +
            " an exception")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void CreatingAJobWithTheTypeThatIsNotDerivedFromTheBackgroundJobCausesAnException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating a job with the type, that is not derived from the \'BackgroundJob\' causes" +
                    " an exception", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 43
     testRunner.When("I create a job with the incorrect type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
     testRunner.Then("A \'System.ArgumentException\' is thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Creating a job with an empty state causes an exception")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void CreatingAJobWithAnEmptyStateCausesAnException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating a job with an empty state causes an exception", ((string[])(null)));
#line 46
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 47
     testRunner.When("I create a job with an empty state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
     testRunner.Then("A \'System.ArgumentNullException\' is thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
