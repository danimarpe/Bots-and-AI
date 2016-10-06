using Microsoft.Bot.Connector;
using System.Threading.Tasks;

namespace BotDanimarpe.PesimistStrategy
{
    public interface IReplyText
    {
        string AnalizeText(Activity activity);
    }
}
