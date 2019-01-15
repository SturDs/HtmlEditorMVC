using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyRichTextMVC.Startup))]
namespace MyRichTextMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
