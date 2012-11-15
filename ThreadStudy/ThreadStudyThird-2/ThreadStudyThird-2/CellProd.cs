using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreadStudyThird_2
{
    public class CellProd
    {
        Cell cell; // 被操作的Cell对象
        int quantity = 1; // 生产者生产次数，初始化为1 

        public CellProd(Cell box, int request)
        {
            //构造函数
            cell = box;
            quantity = request;
        }
        public void ThreadRun()
        {
            for (int looper = 1; looper <= quantity; looper++)
                cell.WriteToCell(looper); //生产者向操作对象写入信息
        }
    }
}
