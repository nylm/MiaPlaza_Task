using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ui_automation_task.Pages
{
    public class MOHSApplicationPage
    {
        private readonly IWebDriver driver;

        public MOHSApplicationPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        IWebElement NextBtn(int pageNum) => driver.FindElement(By.CssSelector($"[page_no='{pageNum}'] button[elname='next']"));
        IWebElement FirstName => driver.FindElement(By.CssSelector("[elname='First']"));
        IWebElement LastName => driver.FindElement(By.CssSelector("[elname='Last']"));
        IWebElement Email => driver.FindElement(By.Id("Email-arialabel"));
        IWebElement PhoneNum => driver.FindElement(By.Id("PhoneNumber"));
        IWebElement SecondParentDropDwon => driver.FindElement(By.Id("select2-Dropdown-arialabel-container"));
        IWebElement SecondParentOption(string option) => driver.FindElement(By.CssSelector($"[id$='-{option}']"));
        IWebElement HearAboutUsOption(string option) => driver.FindElement(By.XPath($"//*[text()='{option}']"));
        IWebElement Datepicker => driver.FindElement(By.Id("Date-date"));



        public void ProceedToNextPage(int currentPageNum)
        {
            NextBtn(currentPageNum).Click();
        }

        public void FillParentInformation(string firstName, string lastName, string email, int phoneNumber)
        {
            FirstName.SendKeys(firstName);
            LastName.SendKeys(lastName);
            Email.SendKeys(email);
            PhoneNum.SendKeys(phoneNumber.ToString());
        }

        public void SelectSecondParentOption(string option)
        {
            SecondParentDropDwon.Click();
            SecondParentOption(option).Click();

            // //the function can be extended if the second parent field required:
            // if(option=="Yes"){
            //     //Fill in second parent information
            // }
        }

        public void SelectHowDidYouHearAboutUs(string option)
        {
            HearAboutUsOption(option).Click();
        }

        public void EnterStartDate(string date)
        {
            Datepicker.SendKeys(date);
            Datepicker.SendKeys(Keys.Return);
        }

    }
}
