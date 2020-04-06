using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarea_01_Introduccion_.Models;

namespace Tarea_01_Introduccion_.Controllers
{
    public class AgendaController : Controller
    {
        public static List<Personas> Lista = new List<Personas>();
        Personas person = new Personas();

        public IActionResult Index(string nom)
        {
                return View(Lista);
        }


        public IActionResult Agregar_Persona()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    person.Nombre = Request.Form["Nombre"];
                    person.Apellido = Request.Form["Apellido"];
                    person.Apodo = Request.Form["Apodo"];
                    person.Telefono = Request.Form["Telefono"];
                    person.Email = Request.Form["Email"];
                    person.Relacion = Request.Form["Email"];


                    Lista.Add(person);
                    return View(person);
                }
                else
                {
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }
    }
}