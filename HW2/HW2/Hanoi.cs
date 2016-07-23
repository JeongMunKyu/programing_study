using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Hanoi
    {
        private HanoiTower[] towers;
        public int NumOfDisks { get; private set; }
        public int Turns { get; private set; }
        public Hanoi() {
            towers = new HanoiTower[3];
            Console.Write("Enter number of disks :");
            NumOfDisks = Convert.ToInt32(Console.ReadLine());
            Turns = 0;
        }
        public void Run() {
            towers[0] = new HanoiTower(NumOfDisks);
            towers[1] = new HanoiTower(NumOfDisks);
            towers[2] = new HanoiTower(NumOfDisks);
            towers[0].InsertAllDisks(NumOfDisks);
            Draw(NumOfDisks, towers[0].Disks, towers[1].Disks, towers[2].Disks);
            ExecuteTurn(NumOfDisks, towers[0], towers[1], towers[2]);
            Draw(NumOfDisks, towers[0].Disks, towers[1].Disks, towers[2].Disks);
            Console.WriteLine("Total need turns: "+Turns);
        }
        private void ExecuteTurn(int n, HanoiTower source, HanoiTower via, HanoiTower dest) {
            if (n == 1) {
                int diskSize = source.DiskCount();
                source.RemoveDisk();
                dest.InsertDisk(diskSize);
                Turns += 1;
                return;
            }
            ExecuteTurn(n - 1, source, dest, via);
            ExecuteTurn(1, source, via, dest);
            ExecuteTurn(n - 1, via, source, dest);
        }
        public void Draw(int n, int[] towerA, int[] towerB, int[] towerC) {
            for (int i = n - 1; i >= 0; i--)
            {
                DrawDisk(n, towerA[i]);
                Console.Write("  ");
                DrawDisk(n, towerB[i]);
                Console.Write("  ");
                DrawDisk(n, towerC[i]);
                Console.WriteLine();
            }
        }
        private void DrawDisk(int n, int diskSize) {
            for (int j = diskSize; j < n + 1; j++)
                Console.Write(" ");
            for (int j = 0; j < diskSize; j++)
                Console.Write("*");
            Console.Write("|");
            for (int j = 0; j < diskSize; j++)
                Console.Write("*");
            for (int j = diskSize; j < n + 1; j++)
                Console.Write(" ");
        }
    }
}
 