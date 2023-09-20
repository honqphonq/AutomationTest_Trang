using AutomationTest_Ngan_CNPM.FileBaseTest;
using AutomationTest_Ngan_CNPM.POM.Admin_POM.AddNewEventPOM;
using AutomationTest_Ngan_CNPM.POM.Admin_POM.LoginAdminPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest_Ngan_CNPM.Script.Admin_Script.TrangSuKien_ThemMoi
{
    public class ThemMoiSuKienThieuBanToChuc : BaseTestAdmin
    {
        [Test, Category("Them Su Kien")]
        public void ThemSuKien()
        {
            var login = new LoginAdminPOM(driver);
            login.LoginSuccess();

            var themSuKien = new AddNewEventPOM(driver);
            themSuKien.ThemMoiThatBai_ThieuBanToChuc();
        }
    }
}
