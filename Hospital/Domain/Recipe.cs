using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain
{
    class Recipe:IRecipe
    {
        Guid Id { get; }
        Guid DoctorId { get; set; }
        Guid PatientId { get; set; }
        List<Medicine> Medicines;
        DateTime Date;
        double TotalCost;

        public Recipe()
        {
            Id = Guid.NewGuid();
            Medicines = new List<Medicine>();
            TotalCost = 0;
            Date = DateTime.Now;
        }

        public void AddMedicine(Medicine medicine)
        {
            Medicines.Add(medicine);
            TotalCost += medicine.Cost;
        }

        public void RemoveMedicine(Medicine medicine)
        {
            Medicines.Remove(medicine);
        }

        public string GetInfo()
        {
            string medicines = "";

            medicines = GetMedicinesInString();

            return $"Date:{Date.ToString()} List of the medicines:{medicines} Total cost:{TotalCost}" ;
        }

        private string GetMedicinesInString()
        {
            string str = "";
            foreach(var m in Medicines)
            {
                str += m.Name + " ";
            }
            return str;
        }
    }
}
