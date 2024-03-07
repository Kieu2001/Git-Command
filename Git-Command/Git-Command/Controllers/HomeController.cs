using Microsoft.AspNetCore.Mvc;

namespace Git_Command.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*
         - Git commit:
           Trước khi commit thì chọn file để commit:
            +Nếu muốn chọn hết các file thì sử dụng lệnh: git add .
            +Nếu muốn chọn tập cụ thể thì sử dụng lênh: git add 
         - Git fetch:
         - Git amend:
         
         */
    }
}
