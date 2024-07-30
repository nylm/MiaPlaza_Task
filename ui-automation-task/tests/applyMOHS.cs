using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ui_automation_task.Pages;
using AventStack.ExtentReports;

namespace ui_automation_task.Tests
{
    [TestFixture]
    public class ApplyMOHS
    {
        private IWebDriver driver;
        private MiaAcademyHomePage homePage;
        private OnlineHighSchoolPage highSchoolPage;
        private MOHSApplicationPage applicationPage;

        [SetUp]
        public void SetUp()
        {
            // Initialize WebDriver
            driver = new ChromeDriver();
            homePage = new MiaAcademyHomePage(driver);
            highSchoolPage = new OnlineHighSchoolPage(driver);
            applicationPage = new MOHSApplicationPage(driver);

            homePage.Navigate();

            // Create a new test in ExtentReports
            ExtentManager.test = ExtentManager.extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void TestApplyToMOHS()
        {
            try
            {
                // Navigate to MiaPrep Online High School page through the link on the banner
                ExtentManager.test.Log(Status.Info, "Navigating to MiaPrep Online High School page");
                homePage.NavigateToOnlineHighSchool();

                // Apply to MOHS
                ExtentManager.test.Log(Status.Info, "Applying to MOHS");
                highSchoolPage.ApplyToMOHS();

                // Click next
                applicationPage.ProceedToNextPage(1);

                // Fill in the Parent Information
                ExtentManager.test.Log(Status.Info, "Filling Parent Information");
                applicationPage.FillParentInformation("Testi", "Tester", "testi.tester@done.com", 1234567890);

                // Second parent Dropdown
                applicationPage.SelectSecondParentOption("No");

                // How did you hear about us?
                applicationPage.SelectHowDidYouHearAboutUs("TikTok");

                // What is your preferred start date?
                applicationPage.EnterStartDate("01-Sep-2024");

                // Proceed to Student Information page
                ExtentManager.test.Log(Status.Info, "Proceeding to Student Information Page");
                applicationPage.ProceedToNextPage(2);

                // Log success
                ExtentManager.test.Log(Status.Pass, "Test passed successfully");
            }
            catch (Exception e)
            {
                // Log failure
                ExtentManager.test.Log(Status.Fail, $"Test failed: {e.Message}");
                throw;
            }
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up WebDriver
            driver.Quit();
            // Log driver quit
            ExtentManager.test.Log(Status.Info, "Driver quit successfully.");
        }
    }
}
