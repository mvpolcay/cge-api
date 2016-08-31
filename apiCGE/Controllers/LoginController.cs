using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiCGE.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public bool loginresult(string username, string password)
        {
            if (username != String.Empty && username != "")
            {
                if (password != String.Empty && password != "")
                {
                    if (username == "demo" && password == "demo")
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }
    }
}
