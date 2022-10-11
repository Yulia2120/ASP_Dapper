using ASP_Dapper.Models;
using ASP_Dapper.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Dapper.Controllers
{
   
        [ApiController]
        [Route("[controller]")]
        public class NoteController : ControllerBase
        {
            [HttpGet("AllNotes")]
            public async Task<ActionResult<List<Note>>> AllNotes()
            {
                return await NoteRepository.GetNotes();


            }


        }
    
}