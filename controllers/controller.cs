using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using MailChimp.Net;

namespace MailChimpIntegration.controllers
{
    public class controller : ApiController
    {

        Dictionary<string, string> _configuration = new Dictionary<string, string>(){
        {"client_id", "YourClientID"},
        {"client_secret", "YourSecret"},
        {"redirect_uri", "http://127.0.0.1:49660/redirect"},
        {"authorize_uri", "https://login.mailchimp.com/oauth2/authorize"},
        {"access_token_uri", "https://login.mailchimp.com/oauth2/token"},
        {"base_uri", "https://login.mailchimp.com/oauth2/"}};
        
        Response.BufferOutput = true;

}
