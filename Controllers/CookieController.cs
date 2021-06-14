using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class CookieController : ControllerBase
    {
        [HttpGet("essential")]
        public async Task<ActionResult> EssentialCookie()
        {
            CookieOptions opt = new CookieOptions
            {
                IsEssential = true
            };
            Response.Cookies.Append("essentialCookie", $"{ Guid.NewGuid()}", opt);
            return Redirect("/");
        }

        [HttpGet("nonessential")]
        public async Task<ActionResult> NonEssentialCookie()
        {
            Response.Cookies.Append("nonessentialCookie", $"{ Guid.NewGuid()}");
            return Redirect("/");
        }

        [HttpGet("consent")]
        public async Task<ActionResult> SetConsent()
        {
            ITrackingConsentFeature consent = HttpContext.Features.Get<ITrackingConsentFeature>();
            if (!consent.CanTrack)
            {
                consent.GrantConsent();
            }
            return Redirect("/");
        }
    }
}