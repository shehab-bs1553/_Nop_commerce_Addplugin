using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.AddTicket.Myticket.Models
{
    public record MyTicketModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Name")]
        public string Name { get; set; }
        [NopResourceDisplayName("Email")]
        public string Email { get; set; }
        [NopResourceDisplayName("Body")]
        public string Body { get; set; }

    }
}
