using OpenQA.Selenium;

namespace AutomationTest_Ngan_CNPM.Consts.LoginPage
{
    public static class LoginPageConsts
    {
        public static By username = By.XPath("//input[contains(@id,'username')]");
        public static By password = By.XPath("//input[contains(@type,'password')]");
        public static By loginButton = By.XPath("//span[@class='p-button-label'][contains(.,'Đăng nhập')]");
        public static By successNoti = By.XPath("//h3[@class='mt-3'][contains(.,'Xin chào Đại lý EMIR')]");
        public static By incorrectPasswordNoti = By.XPath("//span[@class='p-button-label'][contains(.,'Đăng nhập')]");
        public static By notExistingAccount = By.XPath("//div[@role='alert'][contains(.,'Tài khoản không tồn tại')]");
        public static string usernameValue = "DL_EMIR";
        public static string passwordValue = "123456";
        public static string invalidUsernameValue = "invalid";
        public static string invalidPasswordValue = "invalid";
    }
}
