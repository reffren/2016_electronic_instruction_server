using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InstructionForServer.Models
{
    public class Instruction
    {
        [Key]
        public int _id { get; set; }
        public string data_vydachi_zayavki { get; set; }
        public string dolzhnost_vidav_zayavku { get; set; }
        public string rukovod_rabot { get; set; }
        public string teh_karta { get; set; }
        public string data_nomer_prikaza { get; set; }
        public string fio_signal_1 { get; set; }
        public string fio_signal_2 { get; set; }
        public string fio_signal_3 { get; set; }
        public string fio_signal_4 { get; set; }
        public string mesto_km_1 { get; set; }
        public string mesto_pk_1 { get; set; }
        public string mesto_put_1 { get; set; }
        public string mesto_km_2 { get; set; }
        public string mesto_pk_2 { get; set; }
        public string plan_data_rabot { get; set; }
        public string po_soglasovaniyou { get; set; }
        public string date1 { get; set; }
        public string data_c_chasov_1 { get; set; }
        public string data_min_1 { get; set; }
        public string date2 { get; set; }
        public string data_c_chasov_2 { get; set; }
        public string data_min_2 { get; set; }
        public string fio_dispetchera { get; set; }
        public string fio_instructirushego { get; set; }
        public string time_record { get; set; }
    }
}
