using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ZBase.Classes;

namespace ZBase.Utilities
{
    // Credit to whoever made this
    public static class Memory
    {
        public static string WindName = "Counter-Strike: Global Offensive";

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, out int lpNumberOfBytesWritten);

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public static Process Process;
        public static IntPtr ProcessHandle;
        public static IntPtr Client;
        public static IntPtr Engine;
        public static IntPtr vstdlib;
        public static int m_iBytesRead = 0;
        public static int m_iBytesWrite = 0;

        public static T ReadMemory<T>(int Adress) where T : struct
        {
            int ByteSize = Marshal.SizeOf(typeof(T));
            byte[] buffer = new byte[ByteSize];
            ReadProcessMemory((int)ProcessHandle, Adress, buffer, buffer.Length, ref m_iBytesRead);

            return ByteArrayToStructure<T>(buffer);
        }

        public static void WriteMemory<T>(int Adress, object Value)
        {
            byte[] buffer = StructureToByteArray(Value);

            WriteProcessMemory((int)ProcessHandle, Adress, buffer, buffer.Length, out m_iBytesWrite);
        }

        public static float[] ConvertToFloatArray(byte[] bytes)
        {
            if (bytes.Length % 4 != 0)
                throw new ArgumentException();

            float[] floats = new float[bytes.Length / 4];

            for (int i = 0; i < floats.Length; i++)
                floats[i] = BitConverter.ToSingle(bytes, i * 4);

            return floats;
        }

        public static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
        {
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                return (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            }
            finally
            {
                handle.Free();
            }
        }

        public static byte[] StructureToByteArray(object obj)
        {
            int len = Marshal.SizeOf(obj);

            byte[] arr = new byte[len];

            IntPtr ptr = Marshal.AllocHGlobal(len);

            Marshal.StructureToPtr(obj, ptr, true);
            Marshal.Copy(ptr, arr, 0, len);
            Marshal.FreeHGlobal(ptr);

            return arr;
        }

        public static string ReadString(int address, int bufferSize, Encoding enc)
        {
            var buffer = new byte[bufferSize];
            var lpNumberOfBytesRead = 64;
            ReadProcessMemory((int)ProcessHandle, address, buffer, (int)bufferSize, ref lpNumberOfBytesRead);
            var text = enc.GetString(buffer);
            if (text.Contains('\0'))
                text = text.Substring(0, text.IndexOf('\0'));

            return text;
        }
    }

    public class CConVarManager
    {
        public static int pThis;
        public static CharCodes codes;
        public CConVarManager()
        {
            codes = Memory.ReadMemory<CharCodes>((int)Memory.vstdlib + 0x2E000); //8B 3C 85 + 3 vstdlib
            pThis = Memory.ReadMemory<int>((int)Memory.vstdlib + 0x3D8F4); //8B 0D ? ? ? ? C7 05 + 2 vstdlib
        }

        public IntPtr GetConVarAddress(string name)
        {
            var hash = (IntPtr)GetStringHash(name);

            int Pointer = Memory.ReadMemory<int>(Memory.ReadMemory<int>(pThis + 0x34) + ((byte)hash * 4));
            while (Pointer != null)
            {
                if (Memory.ReadMemory<IntPtr>(Pointer) == hash)
                {
                    IntPtr ConVarPointer = Memory.ReadMemory<IntPtr>(Pointer + 0x4);

                    if (Memory.ReadString(Memory.ReadMemory<int>((int)ConVarPointer + 0xC), 64, Encoding.UTF8) == name)
                        return ConVarPointer;
                }
                Pointer = Memory.ReadMemory<int>(Pointer + 0xC);
            }
            return IntPtr.Zero;
        }


        public int GetStringHash(string name)
        {
            int v2 = 0;
            int v3 = 0;
            for (int i = 0; i < name.Length; i += 2)
            {
                v3 = codes.tab[v2 ^ char.ToUpper(name[i])];
                if (i + 1 == name.Length)
                    break;
                v2 = codes.tab[v3 ^ char.ToUpper(name[i + 1])];
            }
            return v2 | (v3 << 8);
        }
    }
}
