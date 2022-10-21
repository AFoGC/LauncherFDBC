using BL_Launcher;
using System.IO;
using UpdaterManager.Views.Interfaces;

namespace UpdaterManager.Presenters
{
    public class LauncherPresenter
    {
        private readonly ILauncherView view;
        public LauncherPresenter(ILauncherView view)
        {
            this.view = view;
        }

        public bool SendNewUpdate()
        {
            byte[] file = File.ReadAllBytes(view.LauncherPath);
            byte[] fileServer = LauncherBL.GetLastUpdate().LauncherFile;
            if (Helper.IsEqualVersions(fileServer, file))
            {
                return false;
            }
            else
            {
                LauncherBL.AddUpdate(file);
                return true;
            }
        }
    }
}
