using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Spas.Startup))]

namespace Spas {
    public partial class Startup {
        public void Configuration( IAppBuilder app ) {
            ConfigureAuth(app);
        }
    }
}
