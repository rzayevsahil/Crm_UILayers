using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.AnnouncementDtos
{
    public class AnnouncementAddDto
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime Date { get; set; }
    }
}
