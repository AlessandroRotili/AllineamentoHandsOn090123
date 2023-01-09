﻿using AllineamentoHandsOn._01_BusinessLayer.models.ad_models;
using AllineamentoHandsOn._01_BusinessLayer.models.images;

namespace AllineamentoHandsOn._01_BusinessLayer.models.company_models
{
    public class CompanyLight
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Image? Logo { get; set; }

    }
}
