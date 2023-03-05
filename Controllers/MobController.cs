using Azure;
using Microsoft.AspNetCore.Mvc;
using QuestsSystem.Data;
using QuestsSystem.Models;

namespace QuestsSystem.Controllers
{
    [Route("Mobs")]
    public class MobController : Controller
    {
        private static QuestContext _mobContext;
        private static IMobRepository _mobRepository;
        public MobController(QuestContext questContext, IMobRepository mobRepository)
        {
            _mobContext = questContext;
            _mobRepository = mobRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMobs()
        {
            var result = await _mobRepository.GetAllMobs();
            return Json(result);
        }
        [Route("{minLevel}/{maxLevel}"), HttpGet]
        public async Task<IActionResult> GetMobsLevelRange(int minLevel, int maxLevel)
        {
            var result = await _mobRepository.GetMobsLevelRange(minLevel, maxLevel);
            return Json(result);
        }
        [Route("{minLevel}/{maxLevel}/{difficulty}"), HttpGet]
        public async Task<IActionResult> GetMobsLevelRangeDifficulty(int minLevel, int maxLevel, Difficulty difficulty)
        {
            var result = await _mobRepository.GetMobsLevelRangeDifficulty(minLevel, maxLevel, difficulty);
            return Json(result);
        }
        [Route("{id}"), HttpGet]
        public async Task<IActionResult> GetMobsWithID(int id)
        {
            var result = await _mobRepository.GetMobsWithID(id);
            return Json(result);
        }

    }
}
