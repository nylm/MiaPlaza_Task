using OpenQA.Selenium;

namespace ui_automation_task.Pages
{
    public class OnlineHighSchoolPage
    {
        private IWebDriver driver;

        public OnlineHighSchoolPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement ApplyNowBtn => driver.FindElement(By.Id("menu-item-4357"));

        public void ApplyToMOHS()
        {
            ApplyNowBtn.Click();
        }
    }
}
