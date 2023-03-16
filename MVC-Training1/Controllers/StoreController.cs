using MVC_Training1.Models;
using MVC_Training1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace MVC_Training1.Controllers
{
    public class StoreController : Controller
    {
        private ApplicationDbContext _context;
        public StoreController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Store
        public ActionResult Index()
        {
            var list = _context.Stores.ToList();

            List<SelectListItem> listSelectListItem = new List<SelectListItem>();
            foreach(var item in list)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.Id.ToString(),
                };
                listSelectListItem.Add(selectListItem);
            }

            StoreViewModel storeViewModel = new StoreViewModel();
            storeViewModel.StoreModels = listSelectListItem;

            return View(storeViewModel);
        }
        public ActionResult view(StoreViewModel storeViewModel)
        {
            int ItemId = Convert.ToInt32(storeViewModel.SelectedItems);
            var ItemDetails = _context.Stores.SingleOrDefault(c => c.Id == ItemId);
            if (ItemDetails == null)
                return HttpNotFound();
            return View(ItemDetails);

        }
    }
}