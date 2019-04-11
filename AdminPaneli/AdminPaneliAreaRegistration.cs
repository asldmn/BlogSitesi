using System.Web.Mvc;

namespace BlogSitesi.Areas.AdminPaneli
{
    //ETicaret gibi çok kapsamlı olmayan projelerde Admin panelini ayrı bir katman olarak yapmaya gerek yok.Projeye Add-->Area dan yeni bir alan açarız. Bu alanda Admin panelini yaparız.
    public class AdminPaneliAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AdminPaneli";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdminPaneli_default",
                "AdminPaneli/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}