using System.Collections.Generic;
using Module.AForge.Models;

namespace Module.AForge.Interfaces
{
    public interface ICaptureDevice
    {
        string Name { get; set; }
        string DeviceSignature { get; set; }
        IEnumerable<string> VideoResolutions { get; set; }
        int Resolution { set; }
        int Width { get; }
        int Height { get; }
        Result StartCapture();
        Result StopCapture();
        bool IsRunning();
    }
}