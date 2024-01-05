﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Data
{
    public class Policy
    {
        public int Id { get; set; }
        public DateTime ApplicationDate { get; set; }

        [ForeignKey("ProductGroup")]
        public ProductGroup ProductGroup { get; set; }
        public int ProductGroupId { get; set; }
        public int Product { get; set; }
        public int ClientId { get; set; }
        public int FirstName { get; set; }
        public int Surname { get; set; }
        public int NationalID { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int Age { get; set; }
        public double AnnualSalary { get; set; }
        public int PremiumTerm { get; set; }
        public double SumAssured { get; set; }
        public double Premium { get; set; }
        public double PremiumPaymentMethod { get; set; }
        public double PremiumPaymentFrequency { get; set; }
    }
}