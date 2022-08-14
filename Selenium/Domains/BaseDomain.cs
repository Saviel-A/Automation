using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Domains
{
    public abstract class BaseDomain
    {
        protected readonly Application Application;

        public BaseDomain(Application application)
        {
            Application = application;
        }
    }
}
