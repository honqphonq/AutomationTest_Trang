using AutomationTest_Ngan_CNPM.Common;
using AutomationTest_Ngan_CNPM.Consts.EventPageConsts;
using AutomationTest_Ngan_CNPM.Consts.HomePageConsts;
using AutomationTest_Ngan_CNPM.Consts.LoginPage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest_Ngan_CNPM.POM.Admin_POM.AddNewEventPOM
{
    public class AddNewEventPOM
    {
        IWebDriver driver;
        public AddNewEventPOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ThemMoiThanhCong()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(HomePageConst.eventButton);
            Thread.Sleep(7000);

            getElement.GetElementAndClick(EventPageConst.Sidebar_NutQuanLySuKien);
            getElement.GetElementAndClick(EventPageConst.Sidebar_NutTongQuanSuKien);
            getElement.GetElementAndClick(EventPageConst.NutThemMoi);

            getElement.GetElementAndSendKey(EventPageConst.Form_TenSuKien, "WORKSHOP LÀM BÁNH TRUNG THU");
            getElement.GetElementAndSendKey(EventPageConst.Form_BanToChuc, "Emir");
            getElement.GetElementAndClick(EventPageConst.Form_LoaiHinhSuKien);
            getElement.GetElementAndClick(EventPageConst.Form_LoaiHinhSuKienLuaChon);

            getElement.GetElementAndClick(EventPageConst.Form_NutLuu);

            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(EventPageConst.ThongBao_ThemThanhCong);
        }

        public void ThemMoiThatBai_ThieuTenSuKien()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(HomePageConst.eventButton);
            Thread.Sleep(7000);

            getElement.GetElementAndClick(EventPageConst.Sidebar_NutQuanLySuKien);
            getElement.GetElementAndClick(EventPageConst.Sidebar_NutTongQuanSuKien);
            getElement.GetElementAndClick(EventPageConst.NutThemMoi);

            //getElement.GetElementAndSendKey(EventPageConst.Form_TenSuKien, "WORKSHOP LÀM BÁNH TRUNG THU");
            getElement.GetElementAndSendKey(EventPageConst.Form_BanToChuc, "Emir");
            getElement.GetElementAndClick(EventPageConst.Form_LoaiHinhSuKien);
            getElement.GetElementAndClick(EventPageConst.Form_LoaiHinhSuKienLuaChon);

            getElement.GetElementAndClick(EventPageConst.Form_NutLuu);

            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(EventPageConst.ThongBao_ThieuTenSuKien);
        }

        public void ThemMoiThatBai_ThieuBanToChuc()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(HomePageConst.eventButton);
            Thread.Sleep(7000);

            getElement.GetElementAndClick(EventPageConst.Sidebar_NutQuanLySuKien);
            getElement.GetElementAndClick(EventPageConst.Sidebar_NutTongQuanSuKien);
            getElement.GetElementAndClick(EventPageConst.NutThemMoi);

            getElement.GetElementAndSendKey(EventPageConst.Form_TenSuKien, "WORKSHOP LÀM BÁNH TRUNG THU");
            //getElement.GetElementAndSendKey(EventPageConst.Form_BanToChuc, "Emir");
            getElement.GetElementAndClick(EventPageConst.Form_LoaiHinhSuKien);
            getElement.GetElementAndClick(EventPageConst.Form_LoaiHinhSuKienLuaChon);

            getElement.GetElementAndClick(EventPageConst.Form_NutLuu);

            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(EventPageConst.ThongBao_ThieuBanToChuc);
        }

        public void ThemMoiThatBai_ThieuLoaiHinhSuKien()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(HomePageConst.eventButton);
            Thread.Sleep(7000);

            getElement.GetElementAndClick(EventPageConst.Sidebar_NutQuanLySuKien);
            getElement.GetElementAndClick(EventPageConst.Sidebar_NutTongQuanSuKien);
            getElement.GetElementAndClick(EventPageConst.NutThemMoi);

            getElement.GetElementAndSendKey(EventPageConst.Form_TenSuKien, "WORKSHOP LÀM BÁNH TRUNG THU");
            getElement.GetElementAndSendKey(EventPageConst.Form_BanToChuc, "Emir");
            //getElement.GetElementAndClick(EventPageConst.Form_LoaiHinhSuKien);
            //getElement.GetElementAndClick(EventPageConst.Form_LoaiHinhSuKienLuaChon);

            getElement.GetElementAndClick(EventPageConst.Form_NutLuu);

            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(EventPageConst.ThongBao_ThieuLoaiHinhSuKien);
        }

    }
}
