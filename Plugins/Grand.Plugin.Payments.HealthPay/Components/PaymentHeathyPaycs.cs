using Microsoft.AspNetCore.Mvc;

namespace Grand.Plugin.Payments.HealthPay.Controllers
{
    [ViewComponent(Name = "PaymentHealthyPay")]
    public class PaymentHealthyPayViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Plugins/Payments.HealthyPay/Views/PaymentHealthyPay/PaymentInfo.cshtml");
        }
    }
}