using Microsoft.AspNetCore.Mvc;

namespace CollegeFestMVC.Controllers
{
    public class FestController : Controller
    {
        private static List<Participant> participants = new List<Participant>();

        public IActionResult Index()
        {
            return View(participants);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Participant participant)
        {
            if (ModelState.IsValid)
            {
                participant.ParticipantId = participants.Count + 1;

                if (participant.RegistrationFee == null)
                {
                    participant.RegistrationFee = 0;
                }

                participant.IsRegistrationCompleted = true;

                participants.Add(participant);

                return RedirectToAction("Index");
            }

            return View(participant);
        }

        public IActionResult Details(int id)
        {
            var participant = participants.FirstOrDefault(
                p => p.ParticipantId == id
            );

            if (participant == null)
            {
                return NotFound();
            }

            return View(participant);
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}