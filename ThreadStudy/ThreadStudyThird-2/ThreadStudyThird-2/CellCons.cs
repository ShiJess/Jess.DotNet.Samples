using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreadStudyThird_2
{
    public class CellCons
    {
        Cell cell;
        int quantity = 1;

        public CellCons(Cell box, int request)
        {
            //构造函数
            cell = box;
            quantity = request;
        }
        public void ThreadRun()
        {
            int valReturned;
            for (int looper = 1; looper <= quantity; looper++)
                valReturned = cell.ReadFromCell();//消费者从操作对象中读取信息
        }
    }
}
