using Chapter_15._03_Implementation_Bridge;
using Chapter_15._04_Examples_Bridge;
using Chapter_15._05_Best_practices_Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinuxRenderer = Chapter_15._03_Implementation_Bridge.LinuxRenderer;
using WindowsRenderer = Chapter_15._03_Implementation_Bridge.WindowsRenderer;

namespace Chapter_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to topic 3 - Implementation Bridge
            UIElement button = new Button(new WindowsRenderer(), "Light");
            button.Render();

            button.Theme = "Dark";
            button.Render();

            button.Renderer = new LinuxRenderer();
            button.Render();

            UIElement testButton = new Button(new MockRenderer(), "TestTheme");
            testButton.Render();


            //to topic 4 - Examples Bridge
            DialogBox dialog = new ConfirmationDialog(new _04_Examples_Bridge.WindowsRenderer());
            dialog.Show("Exit Application", "Are you sure you want to quit?");

            dialog.Renderer = new _04_Examples_Bridge.LinuxRenderer();
            dialog.Show("Exit Application", "Are you sure you want to quit?");

            //to topic 4 - Examples Bridge
            DialogBox mobileDialog = new ConfirmationDialog(new AndroidRenderer());
            mobileDialog.Show("Delete File", "Do you want to remove this file permanently?");

            mobileDialog.Renderer = new IOSRenderer();
            mobileDialog.Show("Delete File", "Do you want to remove this file permanently?");

            //to topic 5 - Best Practices Bridge
            AudioFile song = new Mp3File("track01.mp3", new SpeakerOutput());
            song.Play();

            song.OutputDevice = new BluetoothOutput();
            song.Play();


        }
    }
}
