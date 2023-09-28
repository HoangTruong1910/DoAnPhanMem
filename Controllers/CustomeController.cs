using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using Microsoft.AspNetCore.Mvc;
using QLTTTM.models;

namespace DAPM.Controllers
{
    public class CustomeController : Controller
    {


        private DataSQLContext dataSQLContext;

        public CustomeController(DataSQLContext data)
        {
            dataSQLContext = data;
        }


        public IActionResult TrangChu()
        {
            var data = dataSQLContext;
            return View(data);
        }

        public IActionResult ThuongHieu(int maloai)
        {
            if (maloai == 0)
            {
                List<DoiTac> doiTacs = dataSQLContext.DoiTacs.OrderByDescending(x => x.MADT).ToList();
                ViewBag.tenloadt = "Các Thương Hiệu";
                return View(doiTacs);
                
            }
            else
            {
                
                List<DoiTac> doiTacs = dataSQLContext.DoiTacs.Where(x => x.MALOAIDOITAC == maloai).OrderByDescending(x => x.MADT).ToList();
                LoaiDoiTac? loaiDoiTac = dataSQLContext.LoaiDoiTacs.SingleOrDefault(x => x.MALOAIDT == maloai);
                
                ViewBag.tenloadt = loaiDoiTac.TENLOAI;

                return View(doiTacs);
            }
        }

        public IActionResult TieuDiem()
        {
            List<SuKien> tieudiem = dataSQLContext.SuKiens.Where(x => x.LOAISK == "TD").OrderByDescending(x => x.MASK).ToList();
            return View(tieudiem);
        }

        public IActionResult UuDai()
        {
            List<SuKien> uudai = dataSQLContext.SuKiens.Where(x => x.LOAISK == "UD").OrderByDescending(x => x.MASK).ToList();
            return View(uudai);
        }

        [HttpGet]
        public IActionResult MatBang()
        {
            List<MatBang> list_mb = dataSQLContext.MatBangs.OrderByDescending(x => x.MAMB).Where(x => x.TRANGTHAI == false).ToList();
            return View(list_mb);
        }

        [HttpGet]
        public IActionResult ChiTietMB(int? mamb)
        {
            if (mamb != null)
            {
                MatBang? mb = dataSQLContext.MatBangs.SingleOrDefault(x => x.MAMB == mamb);
                if (mb != null)
                {
                    return View(mb);
                }


            }
            return RedirectToAction("MatBang", "Custome");
        }
    }
}