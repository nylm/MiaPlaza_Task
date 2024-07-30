using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ui_automation_task.Pages;

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
            //Initialize WebDriver
            driver = new ChromeDriver();
            homePage = new MiaAcademyHomePage(driver);
            highSchoolPage = new OnlineHighSchoolPage(driver);
            applicationPage = new MOHSApplicationPage(driver);

            homePage.Navigate();
        }

        [Test]
        public void TestApplyToMOHS()
        {
            // Navigate to MiaPrep Online High School page through the link on the banner
            homePage.NavigateToOnlineHighSchool();

            // Apply to MOHS
            highSchoolPage.ApplyToMOHS();

            // Click next
            applicationPage.ProceedToNextPage(1);

            // Fill in the Parent Information
            applicationPage.FillParentInformation("Testi", "Tester", "testi.tester@done.com", 0123456789);

            // Second parent Dropdown
            applicationPage.SelectSecondParentOption("No");

            // How did you hear about us?
            applicationPage.SelectHowDidYouHearAboutUs("TikTok");

            // What is your preferred start date?
            applicationPage.EnterStartDate("01-Sep-2024");

            // Proceed to Student Information page
            applicationPage.ProceedToNextPage(2);
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up WebDriver
            driver.Quit();
        }
    }
}
