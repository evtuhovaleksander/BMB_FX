using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Midi;

namespace BMB_FX
{
    class SysFunc
    {
        public static ComboBox set_val(object cmb, object item)
        {
            ComboBox outt = (ComboBox)cmb;
            for (int i = 0; i <= 100; i++)
            {
                ComboBox ot = outt;
                ot.SelectedItem = item;
                outt = ot;
                if (outt.SelectedItem != null) break;
            }
            if (outt.SelectedItem == null)
            {
               // MessageBox.Show("Eror in setting Val");
            }
            outt.SelectedItem = item;
           
            return outt;
        }
    }

    //reader = new Mp3FileReader("test.mp3");
    //var waveOut = new WaveOut(); // or WaveOutEvent()
    //waveOut.Init(reader); 
    //waveOut.Play();







    //public class Recorder
    //{

    //    WaveIn sourceStream;
    //    WaveFileWriter waveWriter;
    //    readonly String FilePath;
    //    readonly String FileName;
    //    readonly int InputDeviceIndex;

    //    public Recorder(int inputDeviceIndex, String filePath, String fileName)
    //    {
    //        InitializeComponent();
    //        this.InputDeviceIndex = inputDeviceIndex;
    //        this.FileName = fileName;
    //        this.FilePath = filePath;
    //    }

    //    public void StartRecording(object sender, EventArgs e)
    //    {
    //        sourceStream = new WaveIn
    //        {
    //            DeviceNumber = this.InputDeviceIndex,
    //            WaveFormat =
    //                new WaveFormat(44100, WaveIn.GetCapabilities(this.InputDeviceIndex).Channels)
    //        };

    //        sourceStream.DataAvailable += this.SourceStreamDataAvailable;

    //        if (!Directory.Exists(FilePath))
    //        {
    //            Directory.CreateDirectory(FilePath);
    //        }

    //        waveWriter = new WaveFileWriter(FilePath + FileName, sourceStream.WaveFormat);
    //        sourceStream.StartRecording();
    //    }

    //    public void SourceStreamDataAvailable(object sender, WaveInEventArgs e)
    //    {
    //        if (waveWriter == null) return;
    //        waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
    //        waveWriter.Flush();
    //    }

    //    private void RecordEnd(object sender, EventArgs e)
    //    {
    //        if (sourceStream != null)
    //        {
    //            sourceStream.StopRecording();
    //            sourceStream.Dispose();
    //            sourceStream = null;
    //        }
    //        if (this.waveWriter == null)
    //        {
    //            return;
    //        }
    //        this.waveWriter.Dispose();
    //        this.waveWriter = null;
    //        recordEndButton.Enabled = false;
    //        Application.Exit();
    //        Environment.Exit(0);
    //    }
    //}







}
