using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3._4.Controllers
{
    public class HelperRazorController : Controller
    {
        // GET: HelperRazor
        public ActionResult FormRegister()
        {
            // Tạo list cho droplist
            ViewBag.listEnterprise = new List<Models.Enterprise>()
            {
                new Models.Enterprise(){ID="0",Name="-- Chọn Doanh Nghiệp --"},
                new Models.Enterprise(){ID="DVNN",Name="Đơn vị sự nghiệp nhà nước"},
                new Models.Enterprise(){ID="LT",Name="Lập trình ASP.NET"},
                new Models.Enterprise(){ID="LT1",Name="Lập trình Java"},
                new Models.Enterprise(){ID="LT2",Name="Lập trình PHP"},
                new Models.Enterprise(){ID="LT3",Name="Lập trình Android"},
                new Models.Enterprise(){ID="QT",Name="Quản trị FPT"},
                new Models.Enterprise(){ID="KT",Name="Kế toán"},
                new Models.Enterprise(){ID="BB",Name="Buôn bán ma túy"},
                new Models.Enterprise(){ID="PT",Name="Phân tích thiết kế"},
            };
            return View();
        }
        public ActionResult Register()
        {
            // Lấy giá trị được các trường đẩy lên server khi submit
            string GetEmail = "";
            TempData["UNameDV"] = Request["txtNameDV"];
            TempData["SLNV"] = Request["txtSLNV"];
            TempData["Address"] = Request["txtAddress"];
            TempData["NguoiLH"] = Request["txtNguoiLH"];
            TempData["SDT"] = Request["txtSDT"];
            TempData["Fax"] = Request["txtSoFax"];
            TempData["Email"] = Request["txtEmail"];
            TempData["DCWeb"] = Request["txtDCWeb"];
            TempData["UNameDN"] = Request["txtNameDN"];
            TempData["MK"] = Request["txtPass"];
            TempData["letter"] = GetEmail;
            return View();
        }
    }
}