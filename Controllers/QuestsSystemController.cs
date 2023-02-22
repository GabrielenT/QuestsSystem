using Microsoft.AspNetCore.Mvc;
using QuestsSystem.Data;

namespace QuestsSystem.Controllers
{
    public class QuestsSystemController : Controller
    {
        private static QuestContext _questContext;
        public IActionResult Index()
        {
            return View();
        }
        public QuestsSystemController(QuestContext questContext)
        {
            _questContext = questContext;
        }
        
    }
}
