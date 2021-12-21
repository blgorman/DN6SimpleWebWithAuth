using DN6SimpleWebWithAuth.Models;
using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DN6SimpleWebWithAuth.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TelemetryClient _telemetryClient;

        public HomeController(ILogger<HomeController> logger, TelemetryClient telemetryClient)
        {
            _logger = logger;
            _telemetryClient = telemetryClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DemoLiveInsights()
        {
            _telemetryClient.TrackEvent("EventTracked: Demo Live Insights Viewed");
            try
            {
                throw new Exception("All exceptions can be easily tracked!");
            }
            catch (Exception ex)
            {
                _telemetryClient.TrackException(ex);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}