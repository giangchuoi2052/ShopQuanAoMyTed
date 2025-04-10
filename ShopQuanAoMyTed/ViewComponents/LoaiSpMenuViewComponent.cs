using ShopQuanAoMyTed.Models;
using Microsoft.AspNetCore.Mvc;
using ShopQuanAoMyTed.Repository;
namespace ShopQuanAoMyTed.ViewComponents
{
    public class LoaiSpMenuViewComponent : ViewComponent

    {
        private readonly ILoaiSpRepository _loaiSp;
        public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSpRepository)
        {
            _loaiSp = loaiSpRepository;
        }
        public IViewComponentResult Invoke() 
            {
                var loaisp = _loaiSp.GetAllLoaisp().OrderBy(x=>x.Loai);
                return View(loaisp);
            }
    }
}
