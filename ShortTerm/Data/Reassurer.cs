﻿namespace ShortTerm.Data
{
    public class Reassurer
    {
        public int Id { get; set; }
        public string ClientFullname { get; set; }
        public string Code { get; set; }
        public string Manager { get; set; }
        public string ContractType  { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
    }
}
