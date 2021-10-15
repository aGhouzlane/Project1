using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Web.Controllers
{
    public class FlightsController : Controller
    {
        private readonly IFlightADO _flightADO;

        public FlightsController(IFlightADO flightADO)
        {
            _flightADO = flightADO;
        }
        // GET: FlightsController
        public ActionResult Index()
        {
            IEnumerable<Flight> model = _flightADO.GetFlights();
            return View(model);
        }

        // GET: FlightsController/Details/5
        public ActionResult Details(int id)
        {
            Flight model = _flightADO.GetFlight(id);
            return View(model);
        }

        // GET: FlightsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FlightsController/Create
        [HttpPost]
        public ActionResult Create(Flight flight)
        {
            if (ModelState.IsValid)
            {
                _flightADO.AddFlight(flight);
                return RedirectToAction("Index");
            }
            return View(flight);
        }

        // GET: FlightsController/Edit/5
        public ActionResult Edit(int id)
        {
            Flight model = _flightADO.GetFlight(id);
            return View(model);
        }

        // POST: FlightsController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, [Bind] Flight flight)
        {
            if (ModelState.IsValid)
            {
                _flightADO.UpdateFlight(id, flight);
                return RedirectToAction("Index");
            }
            return View(flight);
        }

        // GET: FlightsController/Delete/5
        public ActionResult Delete(int id)
        {
            Flight model = _flightADO.GetFlight(id);
            return View(model);
        }

        // POST: FlightsController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Flight flight)
        {
            if (ModelState.IsValid)
            {
                _flightADO.DeleteFlight(id);
                return RedirectToAction("Index");
            }
            return View(flight);
        }
    }
}
