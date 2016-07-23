using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class HanoiTower
    {
        private readonly int maxDisks;
        public int[] Disks { get; private set; }
        public int DiskCount()
        {
            int i;
            for (i = 0; i<maxDisks; i++)
            {
                if (Disks[i] == 0)
                    return Disks[i - 1];
                else if (i == maxDisks - 1)
                    return Disks[i];
            }
            return Disks[i - 1];
            //get { }
        }
        public bool Empty()
        {
            return true;
            //get {  }
        }
        public HanoiTower(int numDisk) {
            maxDisks = numDisk;
            Disks = new int[numDisk];
            for (int i = 0; i < numDisk; i++)
                Disks[i] = 0;
        }
        public void InsertAllDisks(int numDisk) {
            for (int i = 0; i < numDisk; i++)
                Disks[i] = numDisk - i;
        }
        public void InsertDisk(int diskSize) {
            int i = 0;
            for (i = 0; i < maxDisks; i++)
            {
                if (Disks[i] == 0)
                {
                    Disks[i] = diskSize;
                    return;
                }
            }
        }
        public void RemoveDisk() {
            int i = 0;
            for (i = 0; i<maxDisks; i++)
            {
                if (Disks[i] == 0)
                {
                    Disks[i - 1] = 0;
                    return;
                }

                else if (i == maxDisks - 1)
                {
                    Disks[i] = 0;
                    return;
                }
            }
        }
    }
}
