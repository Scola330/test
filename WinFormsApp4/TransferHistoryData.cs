using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class TransferHistoryData
    {
        private List<TransferHistoryData> transferHistoryList = new List<TransferHistoryData>();

        public TransferHistoryData() { 
            transferHistoryList = new List<TransferHistoryData>();
            TransferHistory transferHistory = new TransferHistory();
        }
    }
}
