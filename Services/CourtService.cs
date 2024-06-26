﻿using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CourtService
    {
        private readonly CourtRepository CourtRepository = null;
        public CourtService()
        {
            if (CourtRepository == null)
            {
                CourtRepository = new CourtRepository();
            }
        }
        public Court AddCourt(Court Court) => CourtRepository.AddCourt(Court);
        public void DeleteCourt(string id) => CourtRepository.DeleteCourt(id);
        public Court GetCourt(string id) => CourtRepository.GetCourt(id);
        public List<Court> GetCourts() => CourtRepository.GetCourts();
        public Court UpdateCourt(string id, Court Court) => CourtRepository.UpdateCourt(id, Court);
    }
}
