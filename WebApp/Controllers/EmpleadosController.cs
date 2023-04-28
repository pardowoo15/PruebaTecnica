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
    public class EmpleadosController : Controller
    {
        public ActionResult GetEmpl()
        {
            SW_PruebaSoapClient wS_Soap =new  SW_PruebaSoapClient();
            var result = wS_Soap.GetAllEmpl();
            var exit = JsonConvert.DeserializeObject<ResponseHelper>(result);
            if (exit.exitError != 0)
            {
                TempData["ErrorMessage"] = exit.exitMensaje;
                //exit.exitMensaje
                return View("Index");
            }

            List<EmpleadosViewModel> jsonEmpleados = JsonConvert.DeserializeObject<List<EmpleadosViewModel>>(exit.exitValue);
            EmpleadosViewModel model = new EmpleadosViewModel();
            model.Items = jsonEmpleados;


            return View("Index",model);
        }
        public ActionResult CreateEmpl(EmpleadosViewModel model)
        {
            SW_PruebaSoapClient wS_Soap = new SW_PruebaSoapClient();
            var result = wS_Soap.CreateEmpl(model.Nombres, model.Apellidos, model.Direccion, model.Email, model.IdGenero, model.IdCiudad);
            var exit = JsonConvert.DeserializeObject<ResponseHelper>(result);
            if (exit.exitError != 0)
            {
                TempData["ErrorMessage"] = exit.exitMensaje;
                //exit.exitMensaje
                return View("Index");
            }
            List<EmpleadosViewModel> jsonEmpleados = JsonConvert.DeserializeObject<List<EmpleadosViewModel>>(exit.exitValue);
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
