using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBase.Utilities
{
    public class SmartAllocator_t
    {
        public Dictionary<IntPtr, IntPtr> AllocatedSize = new Dictionary<IntPtr, IntPtr>();

        public IntPtr AlloacNewPage(IntPtr size)
        {
            var Address = WinAPI.VirtualAllocEx(Memory.ProcessHandle, IntPtr.Zero, 4096, WinAPI.MEM_COMMIT | WinAPI.MEM_RESERVE, WinAPI.PAGE_READWRITE);

            AllocatedSize.Add(Address, size);

            return Address;
        }

        public void Free()
        {
            foreach (var key in AllocatedSize)
                WinAPI.VirtualFreeEx(Memory.ProcessHandle, key.Key, 4096, WinAPI.MEM_COMMIT | WinAPI.MEM_RESERVE);
        }

        public IntPtr SmartAlloc(int size)
        {
            for (int i = 0; i < AllocatedSize.Count; ++i)
            {
                var key = AllocatedSize.ElementAt(i).Key;
                int value = (int)AllocatedSize[key] + size;
                if (value < 4096)
                {
                    IntPtr CurrentAddres = IntPtr.Add(key, (int)AllocatedSize[key]);
                    AllocatedSize[key] = new IntPtr(value);
                    return CurrentAddres;
                }
            }

            return AlloacNewPage(new IntPtr(size));
        }
    }
}
