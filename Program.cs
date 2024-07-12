// using the program in the directory run a console command to change the monitor's input, causing it to auto seek
using System.Diagnostics;

string strCmdText = @"/c ControlMyMonitor.exe /SetValue \\.\DISPLAY1\Monitor0 60 3";

using (Process myProcess = new Process())
{
    myProcess.StartInfo.Arguments = strCmdText;
    myProcess.StartInfo.UseShellExecute = false;
    // You can start any process, HelloWorld is a do-nothing example.
    myProcess.StartInfo.FileName = "cmd.exe";
    myProcess.StartInfo.CreateNoWindow = true;
    myProcess.Start();
    myProcess.WaitForExit();
    myProcess.Kill();
}