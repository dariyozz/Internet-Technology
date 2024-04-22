using Internet_Tehnologii_Lab2_222015.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Internet_Tehnologii_Lab2_222015.Controllers
{
    public class EventController : Controller
    {
        private static int IDCounter = 1;
        private static List<EventModel> eventModels = new List<EventModel>
        {
            new EventModel {EventID = IDCounter++,Name = "Event1", Location = "Location1" },
            new EventModel {EventID = IDCounter++,Name = "Event2", Location = "Location2" },
            new EventModel {EventID = IDCounter++,  Name = "Event3", Location = "Location3" },
            new EventModel {EventID = IDCounter++,  Name = "Event4", Location = "Location4" },
            new EventModel {EventID = IDCounter++,  Name = "Event5", Location = "Location5" }
        };  

        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayAllEvents()
        {
            return View(eventModels);
        }

        public ActionResult CreateEvent()
        {
            return View();
        }
        public ActionResult DisplayNewEvent(EventModel newEvent)
        {
            if (ModelState.IsValid)
            {
                //Some problems on refresh
                newEvent.EventID = IDCounter++;
                eventModels.Add(newEvent);
                return View(newEvent);
            }
            
            return View("CreateEvent");
            
        }

        public ActionResult Edit(int? id)
        {
            var eventModel = eventModels.Find(m => m.EventID == id);
            return View(eventModel);
        }

        [HttpPost]
        public ActionResult Edit(EventModel updatedModel)
        {
            if (ModelState.IsValid)
            {
                var eventModel = eventModels.Find(m => m.EventID == updatedModel.EventID);
                eventModel.Name = updatedModel.Name;
                eventModel.Location = updatedModel.Location;
                return RedirectToAction("DisplayAllEvents","Event");
            }
            return View(updatedModel);
        }

        public ActionResult Delete(int id)
        {
            var selectedEvent = eventModels.FirstOrDefault(e => e.EventID == id);
            if (selectedEvent == null)
            {
                return HttpNotFound();
            }

            return View(selectedEvent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var selectedEvent = eventModels.FirstOrDefault(e => e.EventID == id);
            if (selectedEvent != null)
            {
                eventModels.Remove(selectedEvent);
                return RedirectToAction("DisplayAllEvents","Event");
            }

            return HttpNotFound();
        }
        
    }
}