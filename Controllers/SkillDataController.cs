using EXCELITAS.data;
using EXCELITAS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EXCELITAS.Controllers
{
    public class SkillDataController : Controller
    {

        private readonly ILogger<SkillDataController> _logger;
        private DbemployeeContext _dbemployeeContext;

        public SkillDataController(ILogger<SkillDataController> logger, DbemployeeContext dbemployeeContext, IHostEnvironment _environment)
        {
            _logger = logger;
            _dbemployeeContext = dbemployeeContext;


        }

        public IActionResult MenuSkillData()
        {
            return View();
                }
		public IActionResult TrackingTraining()
		{
			return View();
		}
		public IActionResult SubTrainingMaster()
		{
			return View();
		}
		public IActionResult MasterTraining()
		{
			return View();
		}
		public IActionResult TrainingList()
		{
			return View();
		}
		public IActionResult SubTrainingTransaction()
		{
			return View();
		}
		public IActionResult Tambah_TrackingTraining()
		{
			return View();
		}
        public IActionResult Tambah_SubTrainingMaster()
        {
            return View();
        }
        public IActionResult Tambah_MasterTraining()
        {
            return View();
        }
        public IActionResult Tambah_TrainingList()
        {
            return View();
        }
        public IActionResult Tambah_SubTrainingTransaction()
        {
            return View();
        }


    }
}
