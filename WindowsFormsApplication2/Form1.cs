using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BluetoothClient Blueclient = new BluetoothClient();
        Dictionary<string, BluetoothAddress> deviceAddresses = new Dictionary<string, BluetoothAddress>();
        BluetoothDeviceInfo device;
        BluetoothDeviceInfo[] Devices;

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.lblMessage.Text = "";
            this.lblMessage.Visible = true;
            BluetoothRadio BlueRadio = BluetoothRadio.PrimaryRadio;
            BlueRadio.Mode = RadioMode.Connectable;
            Devices = Blueclient.DiscoverDevices();
            lsbDevices.Items.Clear();
            addressList.Items.Clear();
            AuthList.Items.Clear();
            deviceAddresses.Clear();
            foreach (BluetoothDeviceInfo device in Devices)
            {
                lsbDevices.Items.Add(device.DeviceName);
                deviceAddresses[device.DeviceName] = device.DeviceAddress;
                addressList.Items.Add(device.DeviceAddress);
                AuthList.Items.Add(device.Authenticated);
                String tempString = "";
                foreach (Guid serviceId in device.InstalledServices)
                {
                    tempString += BluetoothService.GetName(serviceId) + "----";
                }
                Console.Out.WriteLine(tempString);
                Console.Out.WriteLine("=====================");
            }

            this.lblMessage.Text = "Search complete. " + lsbDevices.Items.Count + " bluetooth device found。";

        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
           
            try
            {
                BluetoothAddress DeviceAddress = BluetoothAddress.Parse(targetAddress.Text);

                if (!device.Authenticated)
                {
                    if (BluetoothSecurity.PairRequest(DeviceAddress, "Any passcode"))
                    {
                        MessageBox.Show("Pairing success。");
                    }
                    else
                    {
                        MessageBox.Show("Pairing failed。");
                    }
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Pairing/connecting exception: " + ex.Message);
            }

        }

        private void selectTarget(object sender, EventArgs e)
        {
            targetAddress.Text = (deviceAddresses[lsbDevices.SelectedItem.ToString()]).ToString();

            try
            {
                foreach (BluetoothDeviceInfo d in Devices)
                {
                    if (d.DeviceName == lsbDevices.SelectedItem.ToString())
                        device = d;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Finding devices exception: " + ex.Message);
            }

        }

        private void recieveButton_Click(object sender, EventArgs e)
        {
            try
            {

                Blueclient = new BluetoothClient();

                BluetoothAddress DeviceAddress = BluetoothAddress.Parse(targetAddress.Text);

                device.SetServiceState(BluetoothService.DialupNetworking, true);

                if (device.InstalledServices.Length > 0)
                {
                    try
                    {
                        Blueclient.Connect(DeviceAddress, BluetoothService.DialupNetworking);
                        if(Blueclient.Connected){
                            MessageBox.Show("Connecting success。");
                        }else{
                            MessageBox.Show("Connecting failed。");
                        }


                        //connection established
                        DataBox.Text = "TIME TO RECIEVE DATA FROM " + device.DeviceName;





                        Blueclient.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pairing/connecting exception: " + ex.Message);
            }
        }


    }
}
