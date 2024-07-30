using OpenQA.Selenium;

namespace ui_automation_task.Pages
{
    public class MiaAcademyHomePage
    {
        private IWebDriver driver;

        public MiaAcademyHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://miacademy.co/#/");
            driver.Manage().Window.Maximize();
        }

        public void NavigateToOnlineHighSchool()
        {
            driver.FindElement(By.LinkText("Online High School")).Click();
        }
    }
}
