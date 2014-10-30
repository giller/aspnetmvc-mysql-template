using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace MySqlMVCTemplate.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			ViewData ["Message"] = "If you see this something went wrong";
			var db = new MyDb ();
			var messages = db.Messages.ToList();
			if (messages.Count != null && messages.Count > 0) {
				ViewData ["Message"] = db.Messages.ToList().ElementAt(0).firstname;
			} else {
				var message = new Messages();
				message.firstname = "Hello from your MySql DB";
				db.Messages.Add(message);
				db.SaveChanges();
				ViewData ["Message"] = "Data added to Table, refresh the page to view";
			}
			return View ();
		}
	}
}

