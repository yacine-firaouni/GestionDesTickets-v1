using GestionDesTickets.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionDesTickets.Startup))]
namespace GestionDesTickets
{
    public partial class Startup
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createDefaulteRolesAndUsers();
        }
        public void createDefaulteRolesAndUsers()
        {

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            IdentityRole role = new IdentityRole();
            if (!roleManager.RoleExists("Administrateur"))
            {
                role.Id = "94d640a1-ac27-437e-a928-c10d9d211855";
                role.Name = "Administrateur";
                roleManager.Create(role);
                ApplicationUser user = new ApplicationUser();
                user.UserName = "Admin";
                user.Email = "Admin@gmail.com";
                user.Societe = "OCP";
                user.Sexe = "Masculin";
                var Check = userManager.Create(user, "admin123");
                if (Check.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Administrateur");
                }

            }
            IdentityRole role1 = new IdentityRole();

            if (!roleManager.RoleExists("Technicien "))
            {
                role1.Id = "4e791845-feee-43bd-9665-b47a66aba9d0";
                role1.Name = "Technicien";
                roleManager.Create(role1);
            }
            IdentityRole role2 = new IdentityRole();

            if (!roleManager.RoleExists("utilisateur"))
            {

                role2.Name = "utilisateur";
                roleManager.Create(role2);
            }

        }
    }
}
