using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MSLauncher
{
    public class MapleStoryLauncher
    {
        public static bool LaunchMaple(string id, string pass, string maplestoryPath, string method)
        {
            if (maplestoryPath == "")
                return false;

            var token = "";
            try
            {
                var uid = -1;
                MapleStoryAuth.GetAuthToken(id, pass, out token, out uid);
                if (uid == -1 || token == "")
                    return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(@"An unknown error occured when trying to login.");
                return false;
            }
            var loginString = "";
            try
            {
                loginString = MapleStoryAuth.GetLoginString(token);
                if (loginString == null)
                {
                    MessageBox.Show(@"An error occured when getting Passport.");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"An error occured when getting Passport.");
                return false;
            }
            try
            {
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = maplestoryPath,
                        WorkingDirectory = maplestoryPath.Substring(0, maplestoryPath.LastIndexOf('\\')),
                    }
                };
                if (method == "Web Start")
                    process.StartInfo.Arguments = "WebStart " + loginString;
                else if (method == "Nexon Launcher")
                    process.StartInfo.Arguments = "-nxl " + loginString;

                process.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Unable to start MapleStory.");
                return false;
            }

            return true;
        }
    }
}
