﻿using System.Collections.Generic;

namespace Capstone_Project.Models
{
    public class pharmacy
    {

        public int PharmacyID { get; set; }
        public string PharmacyName { get; set; }
        public int DrugId { get; set; }
        public int DrugPrice { get; set; }
        public int DrugName { get; set; }
        public List<RxDrugs> DrugInfo { get; set; } 
        // not sure if I should use a list of drugs or instanciate all the properties of drug
    }
}
