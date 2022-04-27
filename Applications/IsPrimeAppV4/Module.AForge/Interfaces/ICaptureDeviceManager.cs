using System.Collections.Generic;
using Module.AForge.Models;

namespace Module.AForge.Interfaces
{
    public interface ICaptureDeviceManager
    {
        IEnumerable<CaptureDevice> GetCaptureDevices();
        IEnumerable<string> GetDeviceResolutions(string deviceSignature);
    }
}