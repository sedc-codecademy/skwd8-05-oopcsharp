using System.Collections.Generic;
using Services;
using Services.Data;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            LottoService lottoService = new LottoService();
            UserService userService = new UserService();
            TicketService ticketService = new TicketService();

            lottoService.CreateNewLottoOrganization("Lotarija na Makedonija");
            userService.AddNewUser("Risto", "LM0001");
            userService.AddNewUser("Darko", "LM0002");

            ticketService.CreateNewTicket("LM0001", new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, 20);

            Models.Lotto l = DataHelper.LottoOrganization;
        }
    }
}
