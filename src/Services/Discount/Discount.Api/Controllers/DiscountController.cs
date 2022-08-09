using Microsoft.AspNetCore.Mvc;

namespace Discount.Api.Controllers;

public class DiscountController : Controller
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}