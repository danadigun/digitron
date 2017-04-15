using Digitron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;

public class MessageController : ApiController
{

    // POST api/<controller>
    public async void Post([FromBody]MessageModel message)
    {
        //send message via sms
        await InfoBipService.sendMessage("+2347038025189", message.message+"<br>--From: "+message.name+" "+message.phone);
    }


}