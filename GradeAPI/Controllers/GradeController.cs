using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GradeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GradeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly GradeContext _context;

        public GradeController(GradeContext context)
        {
            _context = context;

            if (_context.GradeItems.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.GradeItems.Add(new GradeItem { Name = "Programação Orientada a Objetos I", Codigo = "GSI009", Horario = "20:50 - 22:30", IsAttended = true, Periodo = 5 });
                _context.SaveChanges();
            }
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GradeItem>>> GetGradeItems()
        {
            return await _context.GradeItems.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GradeItem>> GetTodoItem(long id)
        {
            var gradeItem = await _context.GradeItems.FindAsync(id);

            if (gradeItem == null)
            {
                return NotFound();
            }

            return gradeItem;
        }
    }
}
