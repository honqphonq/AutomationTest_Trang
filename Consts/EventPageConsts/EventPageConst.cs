using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest_Ngan_CNPM.Consts.EventPageConsts
{
    public class EventPageConst
    {
        public static By Sidebar_NutQuanLySuKien = By.XPath("//a[contains(.,'Quản lý sự kiện')]");
        public static By Sidebar_NutTongQuanSuKien = By.XPath("//span[contains(.,'Tổng quan sự kiện')]");
        public static By NutThemMoi = By.XPath("//button[contains(.,'Thêm mới')]");

        public static By Form_TenSuKien = By.XPath("//input[@placeholder='Nhập tên sự kiện']");
        public static By Form_BanToChuc = By.XPath("//input[@placeholder='Nhập ban tổ chức']");
        public static By Form_LoaiHinhSuKien = By.XPath("//span[contains(@class,'p-multiselect-trigger-icon ng-tns-c73-80 pi pi-chevron-down')]");
        public static By Form_LoaiHinhSuKienLuaChon = By.XPath("//span[contains(.,'Vui chơi giải trí')]");

        public static By Form_NutLuu = By.XPath("//button[contains(.,'Thêm mới')]");
        public static By ThongBao_ThieuTenSuKien = By.XPath("//div[@role='alert'][contains(.,'Vui lòng nhập thông tin Tên sự kiện')]");
        public static By ThongBao_ThieuBanToChuc = By.XPath("//div[@role='alert'][contains(.,'Vui lòng nhập thông tin Ban tổ chức')]");
        public static By ThongBao_ThieuLoaiHinhSuKien = By.XPath("//div[@role='alert'][contains(.,'Vui lòng chọn thông tin Loại hình sự kiện')]");
        public static By ThongBao_ThemThanhCong = By.XPath("//div[@role='alert'][contains(.,'Thêm mới thành công')]");
    }
}
