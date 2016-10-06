using Microsoft.Bot.Connector;
using System.Threading.Tasks;

namespace BotDanimarpe.PesimistStrategy
{
    public class Pesimist : IReplyText
    {

        public string AnalizeText(Activity activity)
        {
            if (activity.Text.ToUpper().Contains("HOW"))
                return "Bad";
            else
                return "I don't want to talk about that";
        }
    }
}