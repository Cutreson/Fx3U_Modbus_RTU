using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using Modbus.Device;
namespace Fx3U_Modbus
{
    public static class Modbus_Driver
    {
        public static SerialPort _serialPort = new SerialPort();
        public static ModbusSerialMaster master;
        public static byte slaveID;

        public static void setPort(string portName, int baudRate)
        {
            
            _serialPort.PortName = portName;
            _serialPort.BaudRate = baudRate;
            _serialPort.DataBits = 8;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
        }
        public static bool connect(string portName, int baudRate, byte slaveId)
        {
            try
            {
                _serialPort.Close();
                setPort(portName, baudRate);
                _serialPort.Open();
                slaveID = slaveId;
                master = ModbusSerialMaster.CreateRtu(_serialPort);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public static bool disconnect()
        {
            try
            {
                _serialPort.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public static bool readSingleCoil(ushort startAddress)
        {
            bool[] coils = master.ReadCoils(slaveID, startAddress, 1);
            return coils[0];
        }
        public static ushort readRegister(ushort startAddress)
        {
            ushort[] registers = master.ReadHoldingRegisters(slaveID, startAddress, 1);
            return registers[0];
        }
        public static void writeSingleCoil(ushort coidAddress, bool value)
        {
            master.WriteSingleCoil(slaveID, coidAddress, value);
        }
        public static void writeRegister(ushort registerAddress, ushort value)
        {
            try
            {
                master.WriteSingleRegister(slaveID, registerAddress, value);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
