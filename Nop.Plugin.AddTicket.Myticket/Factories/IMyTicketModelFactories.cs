using Nop.Plugin.AddTicket.Myticket.Domain;
using Nop.Plugin.AddTicket.Myticket.Models;

namespace Nop.Plugin.AddTicket.Myticket.Factories;

public interface IMyTicketModelFactories
{
    Task<MyTicketSearchModel> PrepareMyTicketSearchModelAsync(MyTicketSearchModel searchModel);

    Task<MyTicketListModel> PrepareMyTicketListModelAsync(MyTicketSearchModel searchModel);

    Task<MyTicketModel> PrepareMyTicketModelAsync(MyTicketModel model, MyTicketRecord employee, bool excludeProperties = false);
}