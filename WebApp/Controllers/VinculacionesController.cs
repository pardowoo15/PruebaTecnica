using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Helpers;
using WebApp.Models.ViewModels;
using WebApp.SW_Soap;

namespace WebApp.Controllers
{
    public class VinculacionesController : Controller
    {
        public ActionResult GetVinc()
        {
            SW_PruebaSoapClient wS_Soap =new  SW_PruebaSoapClient();
            var result = wS_Soap.GetAllVinc();
            var exit = JsonConvert.DeserializeObject<ResponseHelper>(result);
            if (exit.exitError != 0)
            {
                TempData["ErrorMessage"] = exit.exitMensaje;
                //exit.exitMensaje
                return View("Index");
            }

            List<VinculacionesViewModels> jsonEmpleados = JsonConvert.DeserializeObject<List<VinculacionesViewModels>>(exit.exitValue);
            VinculacionesViewModels model = new VinculacionesViewModels();
            model.Items = jsonEmpleados;


            return View("Index",model);
        }
        public ActionResult CreateVinc(VinculacionesViewModels model)
        {
            SW_PruebaSoapClient wS_Soap = new SW_PruebaSoapClient();
            var result = wS_Soap.CreateVinc(model.IdEmpleado, model.FechaIngreso.ToString("dd/MM/yyyy"), model.IdCargo, model.FechaRetiro.ToString("dd/MM/yyyy"), model.FechaRegistro.ToString("dd/MM/yyyy"));
            var exit = JsonConvert.DeserializeObject<ResponseHelper>(result);
            if (exit.exitError != 0)
            {
                TempData["ErrorMessage"] = exit.exitMensaje;
                //exit.exitMensaje
                return View("Index");
            }
            List<VinculacionesViewModels> jsonEmpleados = JsonConvert.DeserializeObject<List<VinculacionesViewModels>>(exit.exitValue);
             //result = wS_Soap.GetEmpl(jsonEmpleados.FirstOrDefault().IdEmpleado);




            model.Items = jsonEmpleados;


            return View("Index", model);
        }
        

        public ActionResult Index()
        {

            return View();
        }

        // GET: Empleados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Empleados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleados/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Empleados/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empleados/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
