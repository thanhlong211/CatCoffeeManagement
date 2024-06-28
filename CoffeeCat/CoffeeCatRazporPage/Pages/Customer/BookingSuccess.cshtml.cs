using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoffeeCatRazporPage.Pages.Customer {
    public class BookingSuccessModel : PageModel {
        public void OnGet() {
            Authenticate();
            Authorization();
        }

        private void Authenticate() {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null) {
                HttpContext.Response.Redirect("/Auth/SignIn");
            }
        }

        private void Authorization() {
            int? roleId = HttpContext.Session.GetInt32("RoleId");
            if (roleId.HasValue) {
                if (roleId.Value != 4) {
                    HttpContext.Response.Redirect("/Error/403");
                }
            }
        }
    }
}
