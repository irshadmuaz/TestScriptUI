using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;
using Hardcodet.Wpf.TaskbarNotification;
using System.IO;

namespace TestScript
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        Microsoft.Office.Interop.Excel.Application oXL;
        Microsoft.Office.Interop.Excel._Workbook oWB;
        Microsoft.Office.Interop.Excel._Worksheet oSheet;

        
        DisplayOutput _output;
        string received = "";
        Dictionary<string, string> dict_lga,dict,dict_c2,passed;
        string passphrase = "lol";
        Button active;
        private SerialPort port;
        StreamWriter writer;
        public MainWindow()
        {
            
            if (!Directory.Exists("\\LOG"))
            {
                System.IO.Directory.CreateDirectory("LOG");
            }
            writer = new StreamWriter("LOG\\default_" + DateTime.Now.ToLongDateString() + ".log",true);
            TaskbarIcon tbi = new TaskbarIcon();
            tbi.ToolTipText = "hello world";
            dict_lga = new Dictionary<string, string>() {
            { "lpddr_addrline","lpddr:fvt_addrline" },
            { "lpddr_dataline","lpddr:fvt_dataline" },
            {"nand_probe","nandflash:nand_probe 0 MT29F4G16ABBDA3W" },
            {"nand_scan","nandflash:nand_scan_bbt 0 MT29F4G16ABBDA3W" },
            {"nand_partition","nandflash:nand_check_partitions 0 MT29F4G16ABBDA3W" },
            {"gpio_loopback","gpio:gpio_loopback" },
            {"gpio_wz","gpio:gpio_zero_walk" },
            {"rfgpio_loopback","gpio:gpio_loopback" },
            {"rfgpio_wz","gpio:gpio_zero_walk" },
            {"plcgpio_loopback","gpio:gpio_loopback" },
            {"plcgpio_wz","gpio:gpio_zero_walk" },
            {"usb","FVT_USB:USB_AUTO_TEST" },
            { "i2c_02","i2c0:i2c_slave 0x45 7b:q:i2c2:i2c_master 0 100000 0x45 7b 1024 0xa1" },
            { "i2c_12","i2c1:i2c_slave 0x46 7b:q:i2c2:i2c_master 0 100000 0x46 7b 1024 0xa1" },
            { "spi","spi2:spi_slave 1 1000000 1 0 0 8:q:spi1:spi_master 0 1000000 1 0 0 8 16" },
            {"sdio0","mmc/sdio 0:SDIO_AUTO_TEST" },
            {"sdio1","mmc/sdio 1:SDIO_AUTO_TEST" },
            { "uart3lb","uart3:uart_external_loopback 0 115200 n 8 1 0 100 0xa5" },
            { "uart12","uart1:uart_echo 0 115200 n 8 1 0:q:uart2:uart_external_loopback 0 115200 n 8 1 0 100 0xa5" },
            {"bburam_dv","bburam:bram_data_verify" },
            {"otp_assm_read","otp:lga_assm_read" },
            {"otp_assm_write","otp:lga_assm_write 0 0 0x8 0xC6 0x85 5"},
            {"otp_id_read","otp:brd_id_read" },
            {"otp_id_write","otp:brd_id_write 0x00 0x11 0x22 0x33 0x44 0x55 0x66 0x77" },
            {"bburam_write","bburam:bram_writew 0xaa55"},
            {"otp_cal_read","otp:rtc_cal_read" },
            {"otp_cal_write","otp:rtc_cal_write 33" },

            {"adc0","adc:arm_adc_autotest 0" },
            {"adc1","adc:arm_adc_autotest 1" },
            {"adc2","adc:arm_adc_autotest 2" },
            {"adc3","adc:arm_adc_autotest 3" },
            {"adc4","adc:arm_adc_autotest 4" },
            {"adc5","adc:arm_adc_autotest 5" },
            {"rfadc0","adc:RF_ADC_AUTOTEST 0" },
            {"rfadc1","adc:RF_ADC_AUTOTEST 1" },
            {"rfadc2","adc:RF_ADC_AUTOTEST 2" },
            {"rfadc3","adc:RF_ADC_AUTOTEST 3" },
            {"rfadc4","adc:RF_ADC_AUTOTEST 4" },
            {"rfadc5","adc:RF_ADC_AUTOTEST 5" },
            
        };
            dict_c2 = new Dictionary<string, string>() {
            { "lpddr_addrline","lpddr:fvt_addrline" },
            { "lpddr_dataline","lpddr:fvt_dataline" },
            {"nand_probe","nandflash:nand_probe 0 MT29F4G16ABBDA3W" },
            {"nand_scan","nandflash:nand_scan_bbt 0 MT29F4G16ABBDA3W" },
            {"nand_partition","nandflash:nand_check_partitions 0 MT29F4G16ABBDA3W" },
            {"gpio_loopback","gpio:gpio_loopback" },
            {"gpio_wz","gpio:gpio_zero_walk" },
            {"rfgpio_loopback","gpio:gpio_loopback" },
            {"rfgpio_wz","gpio:gpio_zero_walk" },
            {"plcgpio_loopback","gpio:gpio_loopback" },
            {"plcgpio_wz","gpio:gpio_zero_walk" },
            {"usb","FVT_USB:USB_AUTO_TEST" },
            { "i2c_02","i2c0:i2c_slave 0x45 7b:q:i2c2:i2c_master 0 100000 0x45 7b 1024 0xa1" },
            { "i2c_12","i2c1:i2c_slave 0x46 7b:q:i2c2:i2c_master 0 100000 0x46 7b 1024 0xa1" },
            { "spi","spi2:spi_slave 1 1000000 1 0 0 8:q:spi1:spi_master 0 1000000 1 0 0 8 16" },
            {"sdio0","mmc/sdio 0:SDIO_AUTO_TEST" },
            {"sdio1","mmc/sdio 1:SDIO_AUTO_TEST" },
            { "uart3lb","uart1:uart_external_loopback 0 460800 n 8 1 0 100 0xa6" },
            {"bburam_dv","bburam:bram_data_verify" },
            {"otp_assm_read","otp:lga_assm_read" },
            {"otp_assm_write","otp:lga_assm_write 0 0 0x8 0xC6 0x85 5"},
            {"otp_id_read","otp:brd_id_read" },
            {"otp_id_write","otp:brd_id_write 0x00 0x11 0x22 0x33 0x44 0x55 0x66 0x77" },
            {"bburam_write","bburam:bram_writew 0xaa55"},
            {"otp_cal_read","otp:rtc_cal_read" },
            {"otp_cal_write","otp:rtc_cal_write 33" },

            {"adc0","adc:arm_adc_autotest 0" },
            {"adc1","adc:arm_adc_autotest 1" },
            {"adc2","adc:arm_adc_autotest 2" },
            {"adc3","adc:arm_adc_autotest 3" },
            {"adc4","adc:arm_adc_autotest 4" },
            {"adc5","adc:arm_adc_autotest 5" },
            {"rfadc0","adc:RF_ADC_AUTOTEST 0" },
            {"rfadc1","adc:RF_ADC_AUTOTEST 1" },
            {"rfadc2","adc:RF_ADC_AUTOTEST 2" },
            {"rfadc3","adc:RF_ADC_AUTOTEST 3" },
            {"rfadc4","adc:RF_ADC_AUTOTEST 4" },
            {"rfadc5","adc:RF_ADC_AUTOTEST 5" },
                {"ipm_clear","ipm2:clear_ipm2_int" },
                {"ipm_read","ipm2:read 0 " },
                {"ipm_powerup","ipm2:powerUp" },
                {"ipm_powerdn","ipm2:powerDn" },
                {"ipm_battDis","ipm2:battDisable" },
                {"ipm_battEn","ipm2:battEnable" },
                {"ipm_battMeasure","ipm2:battMeasure" },
                {"ipm_rf_disable","ipm2:rf_5v_disable" },
                {"ipm_rf_enable","ipm2:rf_5v_enable" },
                {"ipm_ldo_disable","ipm2:ldo_24v_disable" },
                {"ipm_ldo_enable","ipm2:ldo_24v_enable" },
                { "ipm_lcd_enable","ipm2:lcd_enable"},
                { "ipm_lcd_disable","ipm2:lcd_disable"},
                {"ipm_rdopen","ipm2:rdsOpen" },
                {"ipm_rdsClose","ipm2:rdsClose" },
                {"ipm_vrdDisable","ipm2:vrdDisable" },
                {"ipm_vrdEnable","ipm2:vrdEnable" },
                {"ipm_rdsRecharge","ipm2:rdsReCharge"},
                {"accel_getid","i2c1:accel_get_id" },
                {"accel_read","i2c1:accel_read_raw_xyz" },
                {"accel_check","i2c1:accel_check_xyz 0 0 16000 2000" }
            };
            
           
            
            //WriteExcel(dict_lga, "ACT_LGA_Commands.xlsx");
            dict = dict_lga;
            InitializeComponent();

            portbox.ItemsSource = SerialPort.GetPortNames();
            output.ScrollToVerticalOffset(500);
            _output = (DisplayOutput)base.DataContext;
        }
        
        private void WriteExcel(Dictionary<string,string> dict,string filename,int col=2)
        {
            try
            {
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = true;
                oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;


                int row = 1;
                foreach (var key in dict.Keys)
                {
                    oSheet.Cells[row, 1] = key;
                    string keyVal;
                    if (dict.TryGetValue(key, out keyVal))
                        oSheet.Cells[row, col] = keyVal;
                    row++;
                }

                oWB.SaveAs("C:\\Users\\mahmad\\Desktop\\" + filename, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
            false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                oWB.Close();
                oXL.Quit();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }
        private Dictionary<string,string> ReadExcel(string filename, Dictionary<string,string> dictionary, int col=2)
        {
           
            if(!System.IO.File.Exists(filename))
            {
                return dictionary;
            }
            
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filename);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            int rows = xlRange.Rows.Count;
            int cols = xlRange.Columns.Count;
            for(int row=1;row<rows;row++)
            {
                if (xlRange.Cells[row, 1] != null && xlRange.Cells[row, 1].Value2 != null)
                    dictionary[xlRange.Cells[row, 1].Value2.ToString()] = xlRange.Cells[row, col].Value2.ToString();
                else
                {
                    break;
                }
                
            }
            xlWorkbook.Close();
            xlApp.Quit();
            return dictionary;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (port != null && port.IsOpen)
                {
                    port.Close();
                    ((Button)e.Source).Content = "Connect";

                    ((Button)e.Source).Background = Brushes.Green;
                }
                else
                {
                    var selectedPort = portbox.SelectedItem.ToString();
                    port = new SerialPort(selectedPort, 115200, Parity.None, 8, StopBits.One);
                    port.Open();
                    ((Button)e.Source).Content = "Disconnect";

                    ((Button)e.Source).Background = Brushes.Red;
                    port.DataReceived += new SerialDataReceivedEventHandler(serial_received);

                }

            }
            catch
            {
                MessageBox.Show("Error!, something went wrong, unable to open port");
            }
        }


        private void serial_received(object sender, SerialDataReceivedEventArgs e)
        {
            var buffer = port.ReadExisting();
            writer.Write(buffer);
            _output.value += buffer;
            received += buffer;
            bool found = false;
            Dispatcher.Invoke(() =>
            {
                output.ScrollToEnd();
                if(passphrase==null)
                {
                    passphrase = "default";
                }
                if (received.Contains(passphrase))
                {
                    //MessageBox.Show("pass phrase found");
                    active.Background = Brushes.ForestGreen;
                    received = "";
                    found = true;
                }
                if (!found)
                {
                    if (received.Contains("cmd:>"))
                    {
                        active.Background = Brushes.Red;
                        received = "";
                    }
                }

            });


        }

        private void portbox_DropDownOpened(object sender, EventArgs e)
        {
            MessageBox.Show("clicked");
            portbox.ItemsSource = SerialPort.GetPortNames();

        }





        private void cmd_Click(object sender, RoutedEventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                string key = ((Button)sender).Name;
                active = (Button)sender;
                port.WriteLine("q");
                Thread.Sleep(100);
                string val;
                if (dict.TryGetValue(key, out val))
                {
                    passed.TryGetValue(key, out passphrase);

                    _output.value = "";
                    writeData(val);

                }
                else
                {
                    MessageBox.Show("No matching instruction for command: " + key);
                }

                Thread.Sleep(100);

            }
            else
            {
                MessageBox.Show("Error! no port connected...!");
            }
        }
        private void writeData(string val)
        {
            string[] commands = val.Split(':');
            foreach (var t in commands)
            {

                port.WriteLine(t);
                Thread.Sleep(100);
            }
        }

        

        private void portbox_MouseEnter(object sender, MouseEventArgs e)
        {
            portbox.ItemsSource = SerialPort.GetPortNames();
        }

        private void log_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                dict_lga = ReadExcel(System.IO.Directory.GetCurrentDirectory() + "\\ACT_LGA_Commands.xlsx", dict_lga);
                dict_c2 = ReadExcel(System.IO.Directory.GetCurrentDirectory() + "\\C2+_Commands.xlsx", dict_c2);
                //MessageBox.Show("Command files successfully loaded\n" + System.IO.Directory.GetCurrentDirectory() + 
                //    "\\ACT_LGA_Commands.xlsx\n"+ System.IO.Directory.GetCurrentDirectory() + "\\C2+_Commands.xlsx");
                MessageBox.Show("Successfully loaded");
            }
            catch
            {
                MessageBox.Show("Command file not loaded, using default instructions");
            }
            
        }

        private void savelog_clock(object sender, RoutedEventArgs e)
        {
            if(filename.Text.Length > 0)
            {
                try
                {
                    writer.Close();
                    writer = new StreamWriter("LOG\\" + filename.Text+"_" + DateTime.Now.ToLongDateString() + ".log");
                    MessageBox.Show("filename changed!");
                }
                catch
                {
                    
                }
                
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            writer.Flush();
            writer.Close();
        }

        private void loadlga_click(object sender, RoutedEventArgs e)
        {
            dict_lga = ReadExcel(System.IO.Directory.GetCurrentDirectory() + "\\ACT_LGA_Commands.xlsx", dict_lga,2);
            passed = new Dictionary<string, string>();
            passed = ReadExcel(System.IO.Directory.GetCurrentDirectory() + "\\ACT_LGA_Commands.xlsx", passed, 3);
            MessageBox.Show("ACT LGA Configuration loaded");
        }

        private void loadc2_click(object sender, RoutedEventArgs e)
        {
            dict_c2 = ReadExcel(System.IO.Directory.GetCurrentDirectory() + "\\C2+_Commands.xlsx", dict_c2);
            MessageBox.Show("C2+ Configuration loaded");
        }

        private void Core_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)Core.IsChecked)
            {
                dict = dict_lga;
            }
        }


        private void Core2_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)Core2.IsChecked)
            {
                dict = dict_c2;
            }
        }
    }
    
}
