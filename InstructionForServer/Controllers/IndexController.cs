using InstructionForServer.Abstract;
using InstructionForServer.Concrete;
using InstructionForServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InstructionForServer.Controllers
{
    public class IndexController : Controller
    {
        Instruction instruction = new Instruction();
        InstructionDbContext context = new InstructionDbContext();

        int i = 0;

        private IInstructionRepository repository;

        public IndexController(IInstructionRepository productRepository)
        {
            repository = productRepository;
        }

        public ViewResult Accept()
        {
            return View();
        }

        public ViewResult List()
        {
            return View(repository.Instructions);
        }

        [HttpPost]
        public void getData()
        {
            while (Request.Form[i] != null)
            {
                instruction.data_vydachi_zayavki = Request.Form[i];
                i++;
                instruction.dolzhnost_vidav_zayavku = Request.Form[i];
                i++;
                instruction.rukovod_rabot = Request.Form[i];
                i++;
                instruction.teh_karta = Request.Form[i];
                i++;
                instruction.data_nomer_prikaza = Request.Form[i];
                i++;
                instruction.fio_signal_1 = Request.Form[i];
                i++;
                instruction.fio_signal_2 = Request.Form[i];
                i++;
                instruction.fio_signal_3 = Request.Form[i];
                i++;
                instruction.fio_signal_4 = Request.Form[i];
                i++;
                instruction.mesto_km_1 = Request.Form[i];
                i++;
                instruction.mesto_pk_1 = Request.Form[i];
                i++;
                instruction.mesto_put_1 = Request.Form[i];
                i++;
                instruction.mesto_km_2 = Request.Form[i];
                i++;
                instruction.mesto_pk_2 = Request.Form[i];
                i++;
                instruction.plan_data_rabot = Request.Form[i];
                i++;
                instruction.po_soglasovaniyou = Request.Form[i];
                i++;
                instruction.date1 = Request.Form[i];
                i++;
                instruction.data_c_chasov_1 = Request.Form[i];
                i++;
                instruction.data_min_1 = Request.Form[i];
                i++;
                instruction.date2 = Request.Form[i];
                i++;
                instruction.data_c_chasov_2 = Request.Form[i];
                i++;
                instruction.data_min_2 = Request.Form[i];
                i++;
                instruction.fio_dispetchera = Request.Form[i];
                i++;
                instruction.fio_instructirushego = Request.Form[i];
                i++;
                instruction.time_record = Request.Form[i];
                i++;

                try
                {
                    var duplicate = repository.Instructions.Where(w => w.time_record == instruction.time_record).Single();
                }
                catch (Exception ex)
                {
                    context.Instructions.Add(instruction);
                    context.SaveChanges();
                }
            }
        }
    }
}