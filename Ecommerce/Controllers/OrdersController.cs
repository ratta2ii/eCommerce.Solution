using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Controllers
{
  public class OrdersController : Controller
  {
    private readonly EcommerceContext _db;

    public OrdersController(EcommerceContext db)
    {
      _db = db;
    }

  }
  
} 

