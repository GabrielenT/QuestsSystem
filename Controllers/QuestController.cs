using Microsoft.AspNetCore.Mvc;
using QuestsSystem.Data;

namespace QuestsSystem.Controllers
{
    [Route("Quests")]
    public class QuestController : Controller
    {
        private static QuestContext _questContext;
        private static IQuestRepository _questRepository;
        public IActionResult Index()
        {
            return View();
        }
        public QuestController(QuestContext questContext, IQuestRepository questRepository)
        {
            _questContext = questContext;
            _questRepository = questRepository;
        }
        [Route("GetQuests"), HttpGet]
        public async Task<IActionResult> GetAllQuests()
        {
            var result = await _questRepository.GetAllQuests();
            return Json(result);
        }
        [Route("GetQuests/{minLevel}/{maxLevel}"), HttpGet]
        public async Task<IActionResult> GetQuestsInLevelRange([FromRoute] int minLevel, [FromRoute] int maxLevel)
        {
            var result = await _questRepository.GetQuestsInLevelRange(minLevel,maxLevel);
            return Json(result);
        }
        [Route("GetQuestsID/{Id}"), HttpGet]
        public async Task<IActionResult> GetQuestsWithID([FromRoute] int id)
        {
            var result = await _questRepository.GetQuestsWithID(id);
            return Json(result);
        }
        public ActionResult PostQuest()
        {
            return View();
        }
        public ActionResult PutQuest()
        {
            return View();
        }
        public ActionResult DeleteQuest()
        {
            return View();
        }
        public ActionResult GetQuestInLevelRange(int Level, int Level2)
        {

            return View();
        }

    }
}
