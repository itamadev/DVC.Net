using Python.Included;
using Python.Runtime;

namespace DVC.Net
{
    public class Client : IDisposable
    {
        private readonly dynamic _DVCApi;

        public Client()
        {
            Installer.SetupPython().Wait();
            var installDVC = Installer.InstallWheel(typeof(Client).Assembly, @"dvc-2.55.0-py3-none-any");
            installDVC.Wait();

            var installDVCS3 = Installer.InstallWheel(typeof(Client).Assembly, @"dvc_s3-2.22.0-py3-none-any");
            installDVCS3.Wait();

            PythonEngine.Initialize();

            _DVCApi = Py.Import("dvc.cli");

        }
         
        public void Pull(string WorkingDir = ".", params string[] ExtraArgs)
        {
            List<string> command = new() { "pull" };
            command.AddRange(ExtraArgs);
            var args = _DVCApi.parse_args(command);
            var prevDirectory = Directory.GetCurrentDirectory();
            try
            {
                Directory.SetCurrentDirectory(WorkingDir);
                var cmd = args.func(args);
                var s = cmd.run();
            }
            finally
            {
                Directory.SetCurrentDirectory(prevDirectory);
            }
        }

        public void Dispose() => PythonEngine.Shutdown();
    }
}