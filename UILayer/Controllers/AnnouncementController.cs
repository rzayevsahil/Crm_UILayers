using System;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    [AllowAnonymous]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDto announcementAddDto)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TInsert(new Announcement()
                {
                    Title = announcementAddDto.Title,
                    Publisher = announcementAddDto.Publisher,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
