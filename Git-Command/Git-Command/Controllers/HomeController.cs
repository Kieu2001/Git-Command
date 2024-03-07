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
           Nếu muốn sửa đổi commit cũ mà không muốn tọa 1 commit mới thì sử dụng lệnh:
           git add . -> git commit --amend -> git push --force origin <Branch name>
         - Git checkout:
           Nếu muốn chuyển từ nhánh A sang nhánh B thì dùng câu lệnh: git checkout B
           Note: Trong trường hợp nhánh A đang có sự thay đổi mà chưa muốn commit
                 thì sử dụng git stash để lưu lại những thay đổi: git stash
                 Muốn lấy lại những thay đổi thì sử dụng lệnh: git
         
         */
    }
}
