using ShopQuanAoMyTed.Models;
namespace ShopQuanAoMyTed.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);
        TLoaiSp Update(TLoaiSp loaiSp);
        TLoaiSp Delete(TLoaiSp maloaiSp);
        TLoaiSp GetLoaiSp(string maloaiSp);
        IEnumerable <TLoaiSp> GetAllLoaisp();


    }
}
