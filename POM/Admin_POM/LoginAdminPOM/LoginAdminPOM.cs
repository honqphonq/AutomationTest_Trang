using AutomationTest_Ngan_CNPM.Common;
using AutomationTest_Ngan_CNPM.Consts.LoginPage;
using OpenQA.Selenium;
using System.Threading;

namespace AutomationTest_Ngan_CNPM.POM.Admin_POM.LoginAdminPOM
{
    public class LoginAdminPOM
    {
        IWebDriver driver;
        public LoginAdminPOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LoginSuccess()
        {
            var getElement = new GetElementAndDoSomething(driver);
            Thread.Sleep(3000);
            getElement.GetElementAndSendKey(LoginPageConsts.username, LoginPageConsts.usernameValue);
            getElement.GetElementAndSendKey(LoginPageConsts.password, LoginPageConsts.passwordValue);
            getElement.GetElementAndClick(LoginPageConsts.loginButton);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(LoginPageConsts.successNoti);
        }

        public void LoginWithNotExistingAccount()
        {
            var getElement = new GetElementAndDoSomething(driver);
            Thread.Sleep(3000);
            getElement.GetElementAndSendKey(LoginPageConsts.username, LoginPageConsts.invalidUsernameValue);
            getElement.GetElementAndSendKey(LoginPageConsts.password, LoginPageConsts.invalidPasswordValue);
            getElement.GetElementAndClick(LoginPageConsts.loginButton);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(LoginPageConsts.notExistingAccount);
        }

        public void LoginWithIncorrectPassword()
        {
            var getElement = new GetElementAndDoSomething(driver);
            Thread.Sleep(3000);
            getElement.GetElementAndSendKey(LoginPageConsts.username, LoginPageConsts.usernameValue);
            getElement.GetElementAndSendKey(LoginPageConsts.password, LoginPageConsts.invalidPasswordValue);
            getElement.GetElementAndClick(LoginPageConsts.loginButton);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(LoginPageConsts.incorrectPasswordNoti);
        }
    }
}
