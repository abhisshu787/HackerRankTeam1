using Microsoft.AspNetCore.Mvc;
using Transact.Models;
using Transact.Services;

namespace Transact.Controllers;

public class TransactionController : ControllerBase
{
    private readonly ITransactionRepository  _transactionrepository;
    private readonly ILogger<TransactionController> _logger;

    public TransactionController(ILogger<TransactionController> logger, ITransactionRepository transactionRepository)  
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _transactionrepository=transactionRepository ?? throw new ArgumentNullException(nameof(transactionRepository));
    }
    
    [HttpGet("getAllPenalities")]
    public async Task<ActionResult<IEnumerable<Transaction>>> GetAllPenalities()
    {
        var entity = await _transactionrepository.GetTransactionAsync();

        return Ok(entity);
    }

}


