using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Web.Controllers
{
    public class PassengersController : Controller
    {
        private readonly IPassengerADO _passengerADO;
        private readonly IFlightADO _flightADO;

        public PassengersController(IPassengerADO passengerADO, IFlightADO flightADO)
        {
            _passengerADO = passengerADO;
            _flightADO = flightADO;
        }
        // GET: PassengersController
        public ActionResult Index()
        {
            IEnumerable<Passenger> model = _passengerADO.GetPassengers();
            return View(model);
        }

        // GET: PassengersController/Details/5
        public ActionResult Details(int id)
        {
            Passenger model = _passengerADO.GetPassenger(id);
            return View(model);
        }

 
        // GET: PassengersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PassengersController/Create
        [HttpPost]
        public ActionResult Create([Bind] Passenger passenger)
        {
            if (ModelState.IsValid) 
            {
                _passengerADO.AddPassenger(passenger, passenger.FlightId);
                return RedirectToAction("Index");
            }
            return View(passenger);
        }

        // GET: PassengersController/Edit/5
        public ActionResult Edit(int id)
        {
            Passenger model = _passengerADO.GetPassenger(id);
            ViewBag.FlightId = new SelectList(_flightADO.GetFlights(), "FlightId", "FlightNumber");
            return View(model);
        }

        // POST: PassengersController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, [Bind] Passenger passenger, int flightId)
        {
            if (ModelState.IsValid)
            {
                _passengerADO.UpdatePassenger(id, passenger);
                _passengerADO.InsertFlight(id, flightId);
                return RedirectToAction("Index");
            }
            return View(passenger);
        }

        // GET: PassengersController/Delete/5
        public ActionResult Delete(int id)
        {
            Passenger model = _passengerADO.GetPassenger(id);
            return View(model);
        }

        // POST: PassengersController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Passenger passenger)
        {
            if (ModelState.IsValid)
            {
                _passengerADO.DeletePassenger(id);
                return RedirectToAction("Index");
            }
            return View(passenger);
        }
    }
}
