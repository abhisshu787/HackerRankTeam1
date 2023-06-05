using Microsoft.AspNetCore.Mvc;
using Transact.Models;
using Transact.Services;

namespace Transact.Controllers;

public class RegisterController : ControllerBase
{
    private readonly IRegisterRepository  _registerrepository;
    private readonly ILogger<RegisterController> _logger;

    public RegisterController(ILogger<RegisterController> logger, IRegisterRepository registerRepository)  
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _registerrepository=registerRepository ?? throw new ArgumentNullException(nameof(registerRepository));
    }
    
  /*  [HttpGet("getAllPenalities")]
    public async Task<ActionResult<IEnumerable<Registration>>> GetAllPenalities()
    {
        var entity = await _registerrepository.GetTransactionAsync();

        return Ok(entity);
    }*/


    [Route("InsertEmployee")]  
        [HttpPost]  
        public object InsertEmployee(Registration Reg)  
        {  
            PenalityContext db=new PenalityContext();
            try  
            {  
  
                Registration r = new Registration();  
                if (r.Id == 0)  
                {  
                    r.Id=Reg.Id;
                    r.FirstName = Reg.FirstName;  
                    r.LastName= Reg.LastName;  
                    r.EmailId= Reg.EmailId;  
                    db.Registrations.Add(r);  
                    db.SaveChanges();  
                    return new Response  
                    { Status = "Success", Message = "Record SuccessFully Saved." };  
                }  
            }  
            catch (Exception)  
            {  
  
                throw;  
            }  
            return new Response  
            { Status = "Error", Message = "Invalid Data." };  
        }  
}

