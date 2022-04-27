using AForge.Video.DirectShow;
using Module.AForge.Interfaces;
using Module.AForge.Models;
using System.Collections.Generic;
using System.Linq;

namespace Module.AForge
{
    public class CaptureDeviceManager : ICaptureDeviceManager
    {
        public IEnumerable<CaptureDevice> GetCaptureDevices()
        {
            return
            (from FilterInfo videoCaptureDevice in new FilterInfoCollection(FilterCategory.VideoInputDevice)
             select new CaptureDevice
             {
                 Name = videoCaptureDevice.Name,
                 DeviceSignature = videoCaptureDevice.MonikerString,
                 VideoResolutions = GetDeviceResolutions(videoCaptureDevice.MonikerString)
             }).ToList();
        }
     
        public IEnumerable<string> GetDeviceResolutions(string deviceSignature)
        {
            var videoCaptureDevice = new VideoCaptureDevice(deviceSignature);

            foreach (var item in videoCaptureDevice.VideoCapabilities)
            {
                yield return $"{item.FrameSize.Width}X{item.FrameSize.Height} - {item.AverageFrameRate} Fps";
            }
        }
    }
}