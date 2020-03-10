using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MediatR;
using TestMediatR.Interface;
using TestMediatR.Memo.Queries.GetMemo.GetMemoQuery;

namespace TestMediatR.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public async Task<string> GetMemo()
        {
            return await _mediator.Send(new GetMemoQueryRequest
            {
                Id = 1
            });
        }
    }
}