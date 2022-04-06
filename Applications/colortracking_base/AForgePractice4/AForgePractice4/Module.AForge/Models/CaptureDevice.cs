using AForge.Video;
using AForge.Video.DirectShow;
using Module.AForge.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Module.AForge.Models
{
    public class CaptureDevice : ICaptureDevice, IDisposable
    {
        private VideoCaptureDevice _videoCaptureDevice;
        public EventHandler<Bitmap> NewFramEventHandler;

        public string Name { get; set; }
        public string DeviceSignature { get; set; }
        public IEnumerable<string> VideoResolutions { get; set; }
        public int Resolution { private get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Result StartCapture()
        {
            var result = new Result() { IsSuccess = true };
            var deviceResult = SetCurrentDevice(DeviceSignature, Resolution);
            if (!deviceResult.IsSuccess)
            {
                result.IsSuccess = deviceResult.IsSuccess;
                result.ErrorMesage = deviceResult.ErrorMesage;
                return result;
            }

            try
            {
                _videoCaptureDevice.Start();

                _videoCaptureDevice.NewFrame -= VideoCaptureDeviceOnNewFrame;
                _videoCaptureDevice.NewFrame += VideoCaptureDeviceOnNewFrame;
                return result;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMesage = $"{ex.InnerException?.Message}";
                return result;
            }
        }
        public Result StopCapture()
        {
            var result = new Result() { IsSuccess = true };
            if (_videoCaptureDevice == null)
            {
                result.IsSuccess = false;
                result.ErrorMesage = "Must be Set Current Video Capture Devices.";
                return result;
            }
            try
            {
                _videoCaptureDevice.Stop();
                return result;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMesage = $"{ex.InnerException?.Message}";
                return result;
            }
        }
        public bool IsRunning()
        {
            return _videoCaptureDevice != null && _videoCaptureDevice.IsRunning;
        }

        private Result SetCurrentDevice(string deviceSignature, int videoResolutionKey)
        {
            var result = new Result() { IsSuccess = true };
            try
            {
                if (_videoCaptureDevice != null)
                {
                    if (_videoCaptureDevice.IsRunning) _videoCaptureDevice.Stop();
                    _videoCaptureDevice = null;
                }

                _videoCaptureDevice = new VideoCaptureDevice(deviceSignature);
                if (_videoCaptureDevice != null)
                    _videoCaptureDevice.VideoResolution = _videoCaptureDevice.VideoCapabilities[videoResolutionKey];

                Width = _videoCaptureDevice.VideoResolution.FrameSize.Width;
                Height = _videoCaptureDevice.VideoResolution.FrameSize.Height;
                return result;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMesage = ex.InnerException?.Message;
                return result;
            }
        }
        private void VideoCaptureDeviceOnNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            NewFramEventHandler(sender, eventArgs.Frame);
        }

        public void Dispose()
        {
            if(_videoCaptureDevice == null) return;
            _videoCaptureDevice.NewFrame -= VideoCaptureDeviceOnNewFrame;

            if (_videoCaptureDevice.IsRunning)
            _videoCaptureDevice.Stop();

            _videoCaptureDevice = null;
        }
    }
}
