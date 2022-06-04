using DashboardApp.DTOs;
using DashboardApp.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TasksApp.Models;

namespace DashboardApp.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly ILogger<AssignmentController> _logger;
        private readonly IAssignmentService _assignmentService;

        public AssignmentController(ILogger<AssignmentController> logger,
            IAssignmentService assignmentService)
        {
            _logger = logger;
            _assignmentService = assignmentService;
        }

        public async Task<IActionResult> Index()
        {
            var listAssignmentDTO = new ListAssignmentDTO();

            listAssignmentDTO.Itens = await _assignmentService.FindBy(listAssignmentDTO.StartDate, listAssignmentDTO.EndDate);

            return View(listAssignmentDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ListAssignmentDTO listAssignmentDTO)
        {
            try
            {
                listAssignmentDTO.Itens = await _assignmentService.FindBy(listAssignmentDTO.StartDate, listAssignmentDTO.EndDate);

                return View(listAssignmentDTO);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("CustomError", ex.Message);
                
                return View(listAssignmentDTO);
            }
            
        }

        public async Task<IActionResult> Create()
        {
            var createAssignmentDTO = new CreateAssignmentDTO();

            return View(createAssignmentDTO);
            /*return RedirectToAction("Index");*/
        }

        [HttpGet]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateAssignmentDTO createAssignmentDTO)
        {
            try
            {
                await _assignmentService.Create(createAssignmentDTO);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("CustomError", ex.Message);
                return View(createAssignmentDTO);
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}