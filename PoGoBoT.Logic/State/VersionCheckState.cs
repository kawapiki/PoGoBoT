#region using directives

using System;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using PoGoBoT.Logic.Event;

#endregion

namespace PoGoBoT.Logic.State
{
    public class VersionCheckState : IState
    {
        public static string VersionUri =
            "https://raw.githubusercontent.com/WooAf/PoGoBoT/master/FeroxRev/PokemonGo.RocketAPI/Properties/AssemblyInfo.cs";

        public IState Execute(Context ctx, StateMachine machine)
        {
            if (!IsLatest())
            {
                machine.Fire(new WarnEvent
                {
                    Message = "There is a new version available: https://github.com/WooAf/PoGoBoT"
                });
            }

            return new LoginState();
        }

        private static string DownloadServerVersion()
        {
            using (var wC = new WebClient())
            {
                return wC.DownloadString(VersionUri);
            }
        }

        public bool IsLatest()
        {
            try
            {
                var regex = new Regex(@"\[assembly\: AssemblyVersion\(""(\d{1,})\.(\d{1,})\.(\d{1,})\.(\d{1,})""\)\]");
                var match = regex.Match(DownloadServerVersion());

                if (!match.Success)
                    return false;

                var gitVersion = new Version($"{match.Groups[1]}.{match.Groups[2]}.{match.Groups[3]}.{match.Groups[4]}");

                if (gitVersion <= Assembly.GetExecutingAssembly().GetName().Version)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return true; //better than just doing nothing when git server down
            }

            return false;
        }
    }
}