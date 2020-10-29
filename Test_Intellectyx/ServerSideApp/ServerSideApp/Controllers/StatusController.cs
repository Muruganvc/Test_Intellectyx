using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerSideApp.interfaces;
using ServerSideApp.models;

namespace ServerSideApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatus _status;
        public StatusController(IStatus status) => _status = status;

        [HttpGet("getStutasDetails")]
        public async Task<IActionResult> getStutasDetails() => Ok(await _status.getStatusDetails());

        [HttpGet("getStutasDetailsById/{statusId}")]
        public async Task<IActionResult> getStutasDetails(int statusId) => Ok(await _status.getStatusDetailsByID(statusId));

        [HttpPost("SaveStatusDetials")]
        public async Task<IActionResult> SaveStatusDetials([FromBody] StatusDetails statusDetails) => Ok(await _status.SaveStatusDetails(statusDetails));
        [HttpPut("UpdateStatusDetials/{statusId}")]
        public async Task<IActionResult> UpdateStatusDetials(int statusId, [FromBody] StatusDetails statusDetails) => Ok(await _status.UpdateStatusDetails(statusId, statusDetails));
        [HttpDelete("DeleteStatusDetials/{statusId}")]
        public async Task<IActionResult> DeleteStatusDetials(int statusId) => Ok(await _status.DeleteStatusDetails(statusId));
    }
}
