using BettingWebbApp.Domain.Abstract;
using Moq;

namespace BettingWebbApp.WebUI.App_Start
{
    internal class Mock<T> : Moq.Mock<IBettingRepository>
    {
    }
}